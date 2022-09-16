using System.Collections.Generic;

namespace 游戏服务器.模板类;

public sealed class C_02_计算目标伤害 : 技能任务
{
	public bool 点爆命中目标;

	public ushort 点爆标记编号;

	public byte 点爆需要层数;

	public bool 失败添加层数;

	public int[] 技能伤害基数;

	public float[] 技能伤害系数;

	public 技能伤害类型 技能伤害类型;

	public 指定目标类型 技能增伤类型;

	public int 技能增伤基数;

	public float 技能增伤系数;

	public bool 数量衰减伤害;

	public float 伤害衰减系数;

	public float 伤害衰减下限;

	public 指定目标类型 技能斩杀类型;

	public float 技能斩杀概率;

	public float 技能破防概率;

	public int 技能破防基数;

	public float 技能破防系数;

	public int 目标硬直时间;

	public bool 目标死亡回复;

	public 指定目标类型 回复限定类型;

	public int 体力回复基数;

	public bool 等级差减回复;

	public int 减回复等级差;

	public int 零回复等级差;

	public bool 增加宠物仇恨;

	public bool 击杀减少冷却;

	public bool 命中减少冷却;

	public 指定目标类型 冷却减少类型;

	public ushort 冷却减少技能;

	public byte 冷却减少分组;

	public ushort 冷却减少时间;

	public bool 扣除武器持久;

	public bool 增加技能经验;

	public ushort 经验技能编号;

	public bool 清除目标状态;

	public HashSet<ushort> 清除状态列表;

	static C_02_计算目标伤害()
	{
	}
}
