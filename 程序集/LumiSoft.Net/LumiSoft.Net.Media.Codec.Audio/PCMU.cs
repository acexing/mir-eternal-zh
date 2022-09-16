using System;

namespace LumiSoft.Net.Media.Codec.Audio;

public class PCMU : AudioCodec
{
	private static readonly byte[] MuLawCompressTable = new byte[256]
	{
		0, 0, 1, 1, 2, 2, 2, 2, 3, 3,
		3, 3, 3, 3, 3, 3, 4, 4, 4, 4,
		4, 4, 4, 4, 4, 4, 4, 4, 4, 4,
		4, 4, 5, 5, 5, 5, 5, 5, 5, 5,
		5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
		5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
		5, 5, 5, 5, 6, 6, 6, 6, 6, 6,
		6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
		6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
		6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
		6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
		6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
		6, 6, 6, 6, 6, 6, 6, 6, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7
	};

	private static readonly short[] MuLawDecompressTable = new short[256]
	{
		-32124, -31100, -30076, -29052, -28028, -27004, -25980, -24956, -23932, -22908,
		-21884, -20860, -19836, -18812, -17788, -16764, -15996, -15484, -14972, -14460,
		-13948, -13436, -12924, -12412, -11900, -11388, -10876, -10364, -9852, -9340,
		-8828, -8316, -7932, -7676, -7420, -7164, -6908, -6652, -6396, -6140,
		-5884, -5628, -5372, -5116, -4860, -4604, -4348, -4092, -3900, -3772,
		-3644, -3516, -3388, -3260, -3132, -3004, -2876, -2748, -2620, -2492,
		-2364, -2236, -2108, -1980, -1884, -1820, -1756, -1692, -1628, -1564,
		-1500, -1436, -1372, -1308, -1244, -1180, -1116, -1052, -988, -924,
		-876, -844, -812, -780, -748, -716, -684, -652, -620, -588,
		-556, -524, -492, -460, -428, -396, -372, -356, -340, -324,
		-308, -292, -276, -260, -244, -228, -212, -196, -180, -164,
		-148, -132, -120, -112, -104, -96, -88, -80, -72, -64,
		-56, -48, -40, -32, -24, -16, -8, 0, 32124, 31100,
		30076, 29052, 28028, 27004, 25980, 24956, 23932, 22908, 21884, 20860,
		19836, 18812, 17788, 16764, 15996, 15484, 14972, 14460, 13948, 13436,
		12924, 12412, 11900, 11388, 10876, 10364, 9852, 9340, 8828, 8316,
		7932, 7676, 7420, 7164, 6908, 6652, 6396, 6140, 5884, 5628,
		5372, 5116, 4860, 4604, 4348, 4092, 3900, 3772, 3644, 3516,
		3388, 3260, 3132, 3004, 2876, 2748, 2620, 2492, 2364, 2236,
		2108, 1980, 1884, 1820, 1756, 1692, 1628, 1564, 1500, 1436,
		1372, 1308, 1244, 1180, 1116, 1052, 988, 924, 876, 844,
		812, 780, 748, 716, 684, 652, 620, 588, 556, 524,
		492, 460, 428, 396, 372, 356, 340, 324, 308, 292,
		276, 260, 244, 228, 212, 196, 180, 164, 148, 132,
		120, 112, 104, 96, 88, 80, 72, 64, 56, 48,
		40, 32, 24, 16, 8, 0
	};

	private AudioFormat m_pAudioFormat = new AudioFormat(8000, 16, 1);

	private AudioFormat m_pCompressedAudioFormat = new AudioFormat(8000, 8, 1);

	public override string Name => "PCMU";

	public override AudioFormat AudioFormat => m_pAudioFormat;

	public override AudioFormat CompressedAudioFormat => m_pCompressedAudioFormat;

	public override byte[] Encode(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentException("Argument 'offset' is out of range.");
		}
		if (count < 1 || count + offset > buffer.Length)
		{
			throw new ArgumentException("Argument 'count' is out of range.");
		}
		if (count % 2 != 0)
		{
			throw new ArgumentException("Invalid buffer value, it doesn't contain 16-bit boundaries.");
		}
		int num = 0;
		byte[] array = new byte[count / 2];
		while (num < array.Length)
		{
			short sample = (short)((buffer[offset + 1] << 8) | buffer[offset]);
			offset += 2;
			array[num++] = LinearToMuLawSample(sample);
		}
		return array;
	}

	public override byte[] Decode(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentException("Argument 'offset' is out of range.");
		}
		if (count < 1 || count + offset > buffer.Length)
		{
			throw new ArgumentException("Argument 'count' is out of range.");
		}
		int num = 0;
		byte[] array = new byte[count * 2];
		for (int i = offset; i < buffer.Length; i++)
		{
			short num2 = MuLawDecompressTable[buffer[i]];
			array[num++] = (byte)((uint)num2 & 0xFFu);
			array[num++] = (byte)((uint)(num2 >> 8) & 0xFFu);
		}
		return array;
	}

	private static byte LinearToMuLawSample(short sample)
	{
		int num = 132;
		int num2 = 32635;
		int num3 = (sample >> 8) & 0x80;
		if (num3 != 0)
		{
			sample = (short)(-sample);
		}
		if (sample > num2)
		{
			sample = (short)num2;
		}
		sample = (short)(sample + num);
		int num4 = MuLawCompressTable[(sample >> 7) & 0xFF];
		int num5 = (sample >> num4 + 3) & 0xF;
		return (byte)(~(num3 | (num4 << 4) | num5));
	}
}
