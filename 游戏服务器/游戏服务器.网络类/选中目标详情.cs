namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 122, 长度 = 0, 注释 = "选中目标详情")]
public sealed class 选中目标详情 : 游戏封包
{
	[封包字段描述(下标 = 4, 长度 = 4)]
	public int 对象编号;

	[封包字段描述(下标 = 8, 长度 = 4)]
	public int 当前体力;

	[封包字段描述(下标 = 12, 长度 = 4)]
	public int 当前魔力;

	[封包字段描述(下标 = 16, 长度 = 4)]
	public int 最大体力;

	[封包字段描述(下标 = 20, 长度 = 4)]
	public int 最大魔力;

	[封包字段描述(下标 = 24, 长度 = 1)]
	public byte[] Buff描述;

	static 选中目标详情()
	{
	}
}
