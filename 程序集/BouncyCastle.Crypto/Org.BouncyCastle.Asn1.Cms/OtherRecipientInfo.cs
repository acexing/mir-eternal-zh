using System;

namespace Org.BouncyCastle.Asn1.Cms;

public class OtherRecipientInfo : Asn1Encodable
{
	private readonly DerObjectIdentifier oriType;

	private readonly Asn1Encodable oriValue;

	public virtual DerObjectIdentifier OriType => oriType;

	public virtual Asn1Encodable OriValue => oriValue;

	public OtherRecipientInfo(DerObjectIdentifier oriType, Asn1Encodable oriValue)
	{
		this.oriType = oriType;
		this.oriValue = oriValue;
	}

	[Obsolete("Use GetInstance() instead")]
	public OtherRecipientInfo(Asn1Sequence seq)
	{
		oriType = DerObjectIdentifier.GetInstance(seq[0]);
		oriValue = seq[1];
	}

	public static OtherRecipientInfo GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, explicitly));
	}

	public static OtherRecipientInfo GetInstance(object obj)
	{
		if (obj == null)
		{
			return null;
		}
		if (obj is OtherRecipientInfo result)
		{
			return result;
		}
		return new OtherRecipientInfo(Asn1Sequence.GetInstance(obj));
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerSequence(oriType, oriValue);
	}
}
