namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 115, 长度 = 6, 注释 = "玩家放弃任务")]
public sealed class 玩家放弃任务 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 对象编号;

	static 玩家放弃任务()
	{
	}
}
