namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 113, 长度 = 14, 注释 = "点击Npcc对话")]
public sealed class 点击Npcc对话 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 对象编号;

	static 点击Npcc对话()
	{
	}
}
