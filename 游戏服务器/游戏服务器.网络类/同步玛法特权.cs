namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 332, 长度 = 3, 注释 = "同步玛法特权")]
public sealed class 同步玛法特权 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 玛法特权;

	static 同步玛法特权()
	{
	}
}
