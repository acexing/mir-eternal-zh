namespace 游戏服务器.模板类;

public sealed class C_06_计算宠物召唤 : 技能任务
{
	public string 召唤宠物名字;

	public bool 怪物召唤同伴;

	public byte[] 召唤宠物数量;

	public byte[] 宠物等级上限;

	public bool 增加技能经验;

	public ushort 经验技能编号;

	public bool 宠物绑定武器;

	public bool 检查技能铭文;

	static C_06_计算宠物召唤()
	{
	}
}
