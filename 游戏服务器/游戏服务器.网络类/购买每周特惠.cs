namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 254, 长度 = 6, 注释 = "购买每周特惠")]
public sealed class 购买每周特惠 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 礼包编号;

	static 购买每周特惠()
	{
	}
}
