namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 1004, 长度 = 849, 注释 = "同步角色列表")]
public sealed class 返回角色列表 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 846)]
	public byte[] 列表描述;

	static 返回角色列表()
	{
	}
}
