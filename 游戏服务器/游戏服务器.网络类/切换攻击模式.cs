namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 38, 长度 = 3, 注释 = "切换攻击模式")]
public sealed class 切换攻击模式 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 攻击模式;

	static 切换攻击模式()
	{
	}
}
