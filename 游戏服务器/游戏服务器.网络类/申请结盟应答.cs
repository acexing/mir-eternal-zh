namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 605, 长度 = 6, 注释 = "申请结盟应答")]
public sealed class 申请结盟应答 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 行会编号;

	static 申请结盟应答()
	{
	}
}
