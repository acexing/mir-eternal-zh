namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 102, 长度 = 3, 注释 = "解锁铭文栏位")]
public sealed class 解锁铭文栏位 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 解锁参数;

	static 解锁铭文栏位()
	{
	}
}
