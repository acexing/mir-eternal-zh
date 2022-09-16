namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 142, 长度 = 0, 注释 = "同步商店版本")]
public sealed class 同步商店数据 : 游戏封包
{
	[封包字段描述(下标 = 4, 长度 = 4)]
	public int 版本编号;

	[封包字段描述(下标 = 8, 长度 = 4)]
	public int 商品数量;

	[封包字段描述(下标 = 12, 长度 = 0)]
	public byte[] 文件内容;

	static 同步商店数据()
	{
	}
}
