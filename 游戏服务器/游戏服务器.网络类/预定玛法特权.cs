namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 217, 长度 = 3, 注释 = "预定玛法特权")]
public sealed class 预定玛法特权 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 特权类型;

	static 预定玛法特权()
	{
	}
}
