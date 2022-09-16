using System;
using System.Collections.Generic;
using LumiSoft.Net.IMAP.Client;

namespace LumiSoft.Net.IMAP;

public class IMAP_Search_Key_Text : IMAP_Search_Key
{
	private string m_Value = "";

	public string Value => m_Value;

	public IMAP_Search_Key_Text(string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		m_Value = value;
	}

	internal static IMAP_Search_Key_Text Parse(StringReader r)
	{
		if (r == null)
		{
			throw new ArgumentNullException("r");
		}
		if (!string.Equals(r.ReadWord(), "TEXT", StringComparison.InvariantCultureIgnoreCase))
		{
			throw new ParseException("Parse error: Not a SEARCH 'TEXT' key.");
		}
		return new IMAP_Search_Key_Text(IMAP_Utils.ReadString(r) ?? throw new ParseException("Parse error: Invalid 'TEXT' value."));
	}

	public override string ToString()
	{
		return "TEXT " + TextUtils.QuoteString(m_Value);
	}

	internal override void ToCmdParts(List<IMAP_Client_CmdPart> list)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		list.Add(new IMAP_Client_CmdPart(IMAP_Client_CmdPart_Type.Constant, "TEXT "));
		list.Add(new IMAP_Client_CmdPart(IMAP_Client_CmdPart_Type.String, m_Value));
	}
}
