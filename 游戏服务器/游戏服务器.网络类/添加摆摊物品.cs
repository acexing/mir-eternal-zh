namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 157, 长度 = 11, 注释 = "添加摆摊物品")]
public sealed class 添加摆摊物品 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 放入位置;

	[封包字段描述(下标 = 3, 长度 = 1)]
	public byte 背包类型;

	[封包字段描述(下标 = 4, 长度 = 1)]
	public byte 物品位置;

	[封包字段描述(下标 = 5, 长度 = 1)]
	public ushort 物品数量;

	[封包字段描述(下标 = 7, 长度 = 4)]
	public int 物品价格;

	static 添加摆摊物品()
	{
	}
}
