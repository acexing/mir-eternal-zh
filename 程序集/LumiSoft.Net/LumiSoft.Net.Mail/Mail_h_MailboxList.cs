using System;
using System.Text;
using LumiSoft.Net.MIME;

namespace LumiSoft.Net.Mail;

public class Mail_h_MailboxList : MIME_h
{
	private string m_ParseValue;

	private string m_Name;

	private Mail_t_MailboxList m_pAddresses;

	public override bool IsModified => m_pAddresses.IsModified;

	public override string Name => m_Name;

	public Mail_t_MailboxList Addresses => m_pAddresses;

	public Mail_h_MailboxList(string filedName, Mail_t_MailboxList values)
	{
		if (filedName == null)
		{
			throw new ArgumentNullException("filedName");
		}
		if (filedName == string.Empty)
		{
			throw new ArgumentException("Argument 'filedName' value must be specified.");
		}
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		m_Name = filedName;
		m_pAddresses = values;
	}

	public static Mail_h_MailboxList Parse(string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		string[] array = value.Split(new char[1] { ':' }, 2);
		if (array.Length != 2)
		{
			throw new ParseException("Invalid header field value '" + value + "'.");
		}
		Mail_h_MailboxList mail_h_MailboxList = new Mail_h_MailboxList(array[0], Mail_t_MailboxList.Parse(array[1].Trim()));
		mail_h_MailboxList.m_ParseValue = value;
		mail_h_MailboxList.m_pAddresses.AcceptChanges();
		return mail_h_MailboxList;
	}

	public override string ToString(MIME_Encoding_EncodedWord wordEncoder, Encoding parmetersCharset, bool reEncode)
	{
		if (reEncode || IsModified)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(Name + ": ");
			for (int i = 0; i < m_pAddresses.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append("\t");
				}
				if (i == m_pAddresses.Count - 1)
				{
					stringBuilder.Append(m_pAddresses[i].ToString(wordEncoder) + "\r\n");
				}
				else
				{
					stringBuilder.Append(m_pAddresses[i].ToString(wordEncoder) + ",\r\n");
				}
			}
			if (m_pAddresses.Count == 0)
			{
				stringBuilder.Append("\r\n");
			}
			return stringBuilder.ToString();
		}
		return m_ParseValue;
	}
}
