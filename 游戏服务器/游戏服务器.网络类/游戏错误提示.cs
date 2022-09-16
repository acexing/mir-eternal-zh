namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 9, 长度 = 14, 注释 = "服务端提示")]
public sealed class 游戏错误提示 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 错误代码;

	[封包字段描述(下标 = 6, 长度 = 4)]
	public int 第一参数;

	[封包字段描述(下标 = 10, 长度 = 4)]
	public int 第二参数;

	static 游戏错误提示()
	{
	}
}
