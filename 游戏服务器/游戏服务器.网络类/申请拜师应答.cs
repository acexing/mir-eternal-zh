namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 549, 长度 = 6, 注释 = "玩家申请拜师")]
public sealed class 申请拜师应答 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 对象编号;

	static 申请拜师应答()
	{
	}
}
