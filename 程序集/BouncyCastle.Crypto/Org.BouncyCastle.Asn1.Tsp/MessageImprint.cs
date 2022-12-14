using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Tsp;

public class MessageImprint : Asn1Encodable
{
	private readonly AlgorithmIdentifier hashAlgorithm;

	private readonly byte[] hashedMessage;

	public AlgorithmIdentifier HashAlgorithm => hashAlgorithm;

	public static MessageImprint GetInstance(object obj)
	{
		if (obj is MessageImprint)
		{
			return (MessageImprint)obj;
		}
		if (obj == null)
		{
			return null;
		}
		return new MessageImprint(Asn1Sequence.GetInstance(obj));
	}

	private MessageImprint(Asn1Sequence seq)
	{
		if (seq.Count != 2)
		{
			throw new ArgumentException("Wrong number of elements in sequence", "seq");
		}
		hashAlgorithm = AlgorithmIdentifier.GetInstance(seq[0]);
		hashedMessage = Asn1OctetString.GetInstance(seq[1]).GetOctets();
	}

	public MessageImprint(AlgorithmIdentifier hashAlgorithm, byte[] hashedMessage)
	{
		this.hashAlgorithm = hashAlgorithm;
		this.hashedMessage = hashedMessage;
	}

	public byte[] GetHashedMessage()
	{
		return hashedMessage;
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerSequence(hashAlgorithm, new DerOctetString(hashedMessage));
	}
}
