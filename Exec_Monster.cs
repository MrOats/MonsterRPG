using System;

namespace MonsterRPG
{
	public class Exec_Monster
	{
		public static void Main(string[] args){
			Monster[] monsterid={
			new Monster("Goblin",10),
			new Monster("Elf", 8),
			new Monster("Ant", 3),
			new Monster("Worm", 2),
			new Monster("Black Widow",6)};

			Battle battle = new Battle(monsterid);
			while (battle.isWonloss()) {
				battle.battle();
				System.Threading.Thread.Sleep(1500);
			}
	}
}
}
