namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 150, 长度 = 6, 注释 = "玩家放入物品")]
public sealed class 玩家放入物品 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 放入位置;

	[封包字段描述(下标 = 3, 长度 = 1)]
	public byte 放入物品;

	[封包字段描述(下标 = 4, 长度 = 1)]
	public byte 物品容器;

	[封包字段描述(下标 = 5, 长度 = 1)]
	public byte 物品位置;

	static 玩家放入物品()
	{
	}
}
