using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonsterRPG
{

	public class Exec_Monster
	{
		public static Monster[] monsterid={
		new Monster("Goblin",10),
		new Monster("Elf", 8),
		new Monster("Ant", 3),
		new Monster("Worm", 2),
		new Monster("Black Widow",6)};
		public static void Main(string[] args){

			//Make GUI
			Application.Run(new GUISystem());
	}
		public static void beginfight(object obj, EventArgs e){
		Battle battle = new Battle(monsterid);
		while (battle.isWonloss()) {
			battle.battle();
			System.Threading.Thread.Sleep(1500);
		}
	}
}

}
