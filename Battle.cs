using System;
namespace MonsterRPG
{
	public class Battle
	{
		private bool wonloss=true;
		public Monster[] monsters;

		public Battle (Monster[] getmonsters)
		{
			monsters = getmonsters;
		}
		public bool isWonloss() {
			return wonloss;
		}

		public void battle() {
			Random chooser=new Random();
			int chosenmonster=chooser.Next(5);
			double defeated=(chooser.NextDouble()*(monsters[chosenmonster].returnHealth())+1);
			Console.WriteLine("The monster you are fighting is "+monsters[chosenmonster].returnName()+" and has "+monsters[chosenmonster].returnHealth()+" HP.");
			GUISystem.displaybar.Text="The monster you are fighting is "+monsters[chosenmonster].returnName()+" and has "+monsters[chosenmonster].returnHealth()+" HP.";
			GUISystem.displaybar.Refresh();
			if (defeated>=(monsters[chosenmonster].returnHealth()/2)){
				Console.WriteLine("You beat "+monsters[chosenmonster].returnName()+"!");
				GUISystem.wonloss_status.Text=("You beat "+(monsters[chosenmonster].returnName())+"!");
				GUISystem.wonloss_status.Refresh();
				wonloss=true;
			}
			else if(defeated<(monsters[chosenmonster].returnHealth()/2)){
				Console.WriteLine("You lost to "+monsters[chosenmonster].returnName()+"!");
				GUISystem.wonloss_status.Text="You lost to "+monsters[chosenmonster].returnName()+"!";
				GUISystem.wonloss_status.Refresh();
				wonloss=false;
			}
	}

	}
}
