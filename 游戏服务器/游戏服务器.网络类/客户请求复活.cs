namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 24, 长度 = 3, 注释 = "玩家请求复活")]
public sealed class 客户请求复活 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 复活方式;

	static 客户请求复活()
	{
	}
}
