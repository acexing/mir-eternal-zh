namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 19, 长度 = 10, 注释 = "请求对象数据, 对应服务端0041封包")]
public sealed class 请求对象数据 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 对象编号;

	[封包字段描述(下标 = 6, 长度 = 4)]
	public int 状态编号;

	static 请求对象数据()
	{
	}
}
