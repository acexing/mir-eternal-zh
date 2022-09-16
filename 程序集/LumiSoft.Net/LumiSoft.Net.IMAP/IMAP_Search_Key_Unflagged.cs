using System;
using System.Collections.Generic;
using LumiSoft.Net.IMAP.Client;

namespace LumiSoft.Net.IMAP;

public class IMAP_Search_Key_Unflagged : IMAP_Search_Key
{
	internal static IMAP_Search_Key_Unflagged Parse(StringReader r)
	{
		if (r == null)
		{
			throw new ArgumentNullException("r");
		}
		if (!string.Equals(r.ReadWord(), "UNFLAGGED", StringComparison.InvariantCultureIgnoreCase))
		{
			throw new ParseException("Parse error: Not a SEARCH 'UNFLAGGED' key.");
		}
		return new IMAP_Search_Key_Unflagged();
	}

	public override string ToString()
	{
		return "UNFLAGGED";
	}

	internal override void ToCmdParts(List<IMAP_Client_CmdPart> list)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		list.Add(new IMAP_Client_CmdPart(IMAP_Client_CmdPart_Type.Constant, ToString()));
	}
}
