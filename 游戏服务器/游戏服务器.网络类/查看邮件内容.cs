namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 549, 长度 = 14, 注释 = "查看邮件内容")]
public sealed class 查看邮件内容 : 游戏封包
{
	[封包字段描述(下标 = 6, 长度 = 4)]
	public int 邮件编号;

	static 查看邮件内容()
	{
	}
}
