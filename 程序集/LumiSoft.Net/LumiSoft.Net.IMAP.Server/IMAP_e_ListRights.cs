using System;

namespace LumiSoft.Net.IMAP.Server;

public class IMAP_e_ListRights : EventArgs
{
	private IMAP_r_u_ListRights m_pListRightsResponse;

	private IMAP_r_ServerStatus m_pResponse;

	private string m_Folder;

	private string m_Identifier;

	public IMAP_r_u_ListRights ListRightsResponse
	{
		get
		{
			return m_pListRightsResponse;
		}
		set
		{
			m_pListRightsResponse = value;
		}
	}

	public IMAP_r_ServerStatus Response
	{
		get
		{
			return m_pResponse;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_pResponse = value;
		}
	}

	public string Folder => m_Folder;

	public string Identifier => m_Identifier;

	internal IMAP_e_ListRights(string folder, string identifier, IMAP_r_ServerStatus response)
	{
		if (folder == null)
		{
			throw new ArgumentNullException("folder");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		m_Folder = folder;
		m_Identifier = identifier;
		m_pResponse = response;
	}
}
