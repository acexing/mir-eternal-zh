namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 349, 长度 = 14, 注释 = "同步技能计数")]
public sealed class 同步技能计数 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 2)]
	public ushort 技能编号;

	[封包字段描述(下标 = 6, 长度 = 1)]
	public byte 技能计数;

	[封包字段描述(下标 = 10, 长度 = 4)]
	public int 技能冷却;

	static 同步技能计数()
	{
	}
}
