using System;

namespace 游戏服务器;

public static class 自定义类
{
	public static string 游戏数据目录;

	public static string 数据备份目录;

	public static ushort 客户连接端口;

	public static ushort 门票接收端口;

	public static ushort 封包限定数量;

	public static ushort 异常屏蔽时间;

	public static ushort 掉线判定时间;

	public static byte 游戏开放等级;

	public static byte 新手扶持等级;

	public static decimal 装备特修折扣;

	public static decimal 怪物额外爆率;

	public static decimal 怪物经验倍率;

	public static ushort 减收益等级差;

	public static decimal 收益减少比率;

	public static ushort 怪物诱惑时长;

	public static ushort 物品归属时间;

	public static ushort 物品清理时间;

	public static byte 武斗场时间一;

	public static byte 武斗场时间二;
	
	public static byte 攻沙开始时间;

	public static byte 攻沙结束时间;

	static 自定义类()
	{
		武斗场时间一 = 13;
		武斗场时间二 = 21;
		攻沙开始时间 = 20;
		攻沙结束时间 = 21;
	}
}
