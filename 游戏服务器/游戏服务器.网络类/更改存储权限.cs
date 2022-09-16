namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 572, 长度 = 5, 注释 = "更改存储权限")]
public sealed class 更改存储权限 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 行会职位;

	[封包字段描述(下标 = 3, 长度 = 1)]
	public byte 原有位置;

	[封包字段描述(下标 = 4, 长度 = 1)]
	public byte 目标页面;

	static 更改存储权限()
	{
	}
}
