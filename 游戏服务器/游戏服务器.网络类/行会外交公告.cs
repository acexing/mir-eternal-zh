namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 641, 长度 = 258, 注释 = "行会外交公告")]
public sealed class 行会外交公告 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 256)]
	public byte[] 字节数据;

	static 行会外交公告()
	{
	}
}
