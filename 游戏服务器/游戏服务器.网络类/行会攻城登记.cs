namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 663, 长度 = 6, 注释 = "行会攻城登记")]
public sealed class 行会攻城登记 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 行会编号;

	static 行会攻城登记()
	{
	}
}
