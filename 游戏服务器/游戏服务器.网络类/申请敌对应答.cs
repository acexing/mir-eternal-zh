namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 642, 长度 = 10, 注释 = "申请敌对应答")]
public sealed class 申请敌对应答 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 行会编号;

	[封包字段描述(下标 = 6, 长度 = 4)]
	public int 需要资金;

	static 申请敌对应答()
	{
	}
}
