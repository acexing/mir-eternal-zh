namespace 游戏服务器.网络类;

[封包信息描述(来源 = 封包来源.服务器, 编号 = 1008, 长度 = 6, 注释 = "永久删除角色回应")]
public sealed class 永久删除角色 : 游戏封包
{
	[封包字段描述(下标 = 2, 长度 = 4)]
	public int 角色编号;

	static 永久删除角色()
	{
	}
}
