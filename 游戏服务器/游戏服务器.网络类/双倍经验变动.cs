namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 76, 长度 = 6, 注释 = "双倍经验变动")]
public sealed class 双倍经验变动 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 双倍经验;

	static 双倍经验变动()
	{
	}
}
