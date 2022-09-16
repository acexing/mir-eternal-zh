namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 71, 长度 = 6, 注释 = "传承武器铭文")]
public sealed class 传承武器铭文 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 来源类型;

	[封包字段描述(下标 = 3, 长度 = 1)]
	public byte 来源位置;

	[封包字段描述(下标 = 4, 长度 = 1)]
	public byte 目标类型;

	[封包字段描述(下标 = 5, 长度 = 1)]
	public byte 目标位置;

	static 传承武器铭文()
	{
	}
}
