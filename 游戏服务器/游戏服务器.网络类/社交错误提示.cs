namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 514, 长度 = 14, 注释 = "聊天服务器错误提示")]
public sealed class 社交错误提示 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 错误编号;

	[封包字段描述(下标 = 6, 长度 = 4)]
	public int 参数一;

	[封包字段描述(下标 = 10, 长度 = 4)]
	public int 参数二;

	static 社交错误提示()
	{
	}
}
