namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.客户端, 编号 = 178, 长度 = 3, 注释 = "查询行会战史")]
public sealed class 查询行会战史 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 宠物模式;

	static 查询行会战史()
	{
	}
}
