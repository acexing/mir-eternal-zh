namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 74, 长度 = 5, 注释 = "解锁双铭文位")]
public sealed class 解锁双铭文位 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 装备类型;

	[封包字段描述(下标 = 3, 长度 = 1)]
	public byte 装备位置;

	[封包字段描述(下标 = 4, 长度 = 1)]
	public byte 操作参数;

	static 解锁双铭文位()
	{
	}
}
