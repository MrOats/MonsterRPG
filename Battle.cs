using System;

namespace Test
{
	public class Battle
	{
		private bool wonloss=true;
		private Monster[] monsters;

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
			if (defeated>=3){
				Console.WriteLine("You beat "+monsters[chosenmonster].returnName()+"!");
				wonloss=true;
			}
			else if(defeated<3){
				Console.WriteLine("You lost to "+monsters[chosenmonster].returnName()+"!");
				wonloss=false;
			}
		}
	}
}
