using System;

namespace Test
{
	public class Monster
	{
		public int hp;
		public String n;
		public Monster(String name,int health){
			n=name;
			hp=health;
		}
		public int returnHealth(){
			return hp;
		}
		public String returnName(){
			return n;
		}
	}
}
