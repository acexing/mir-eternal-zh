using System;
using System.IO;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Parameters;

public sealed class Ed25519PublicKeyParameters : AsymmetricKeyParameter
{
	public static readonly int KeySize = Ed25519.PublicKeySize;

	private readonly byte[] data = new byte[KeySize];

	public Ed25519PublicKeyParameters(byte[] buf, int off)
		: base(privateKey: false)
	{
		Array.Copy(buf, off, data, 0, KeySize);
	}

	public Ed25519PublicKeyParameters(Stream input)
		: base(privateKey: false)
	{
		if (KeySize != Streams.ReadFully(input, data))
		{
			throw new EndOfStreamException("EOF encountered in middle of Ed25519 public key");
		}
	}

	public void Encode(byte[] buf, int off)
	{
		Array.Copy(data, 0, buf, off, KeySize);
	}

	public byte[] GetEncoded()
	{
		return Arrays.Clone(data);
	}
}
