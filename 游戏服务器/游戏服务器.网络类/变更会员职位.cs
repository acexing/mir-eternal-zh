namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 565, 长度 = 7, 注释 = "变更会员职位")]
public sealed class 变更会员职位 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 对象编号;

	[封包字段描述(下标 = 6, 长度 = 1)]
	public byte 对象职位;

	static 变更会员职位()
	{
	}
}
