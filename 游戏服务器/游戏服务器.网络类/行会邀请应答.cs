namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 595, 长度 = 35, 注释 = "行会邀请应答")]
public sealed class 行会邀请应答 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 1)]
	public byte 应答类型;

	[封包字段描述(下标 = 3, 长度 = 32)]
	public string 对象名字;

	static 行会邀请应答()
	{
	}
}
