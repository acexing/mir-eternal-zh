namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 250, 长度 = 38, 注释 = "玩家屏蔽目标")]
public sealed class 玩家屏蔽目标 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 对象编号;

	[封包字段描述(下标 = 6, 长度 = 32)]
	public string 对象名字;

	static 玩家屏蔽目标()
	{
	}
}
