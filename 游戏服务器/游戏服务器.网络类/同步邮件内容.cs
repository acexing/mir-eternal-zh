namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 575, 长度 = 674, 注释 = "查询邮件内容")]
public sealed class 同步邮件内容 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 672)]
	public byte[] 字节数据;

	static 同步邮件内容()
	{
	}
}
