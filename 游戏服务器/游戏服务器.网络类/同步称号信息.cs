namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 24, 长度 = 0, 注释 = "同步称号信息")]
public sealed class 同步称号信息 : 游戏封包
{
	[封包字段描述(下标 = 4, 长度 = 0)]
	public byte[] 字节描述;

	static 同步称号信息()
	{
	}
}
