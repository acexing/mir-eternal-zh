namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 522, 长度 = 38, 注释 = "添加好友关注")]
public sealed class 添加好友关注 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 对象编号;

	[封包字段描述(下标 = 6, 长度 = 32)]
	public string 对象名字;

	static 添加好友关注()
	{
	}
}
