namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 241, 长度 = 4, 注释 = "玩家喝修复油")]
public sealed class 玩家喝修复油 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 背包类型;

	[封包字段描述(下标 = 3, 长度 = 1)]
	public byte 物品位置;

	static 玩家喝修复油()
	{
	}
}
