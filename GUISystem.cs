using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonsterRPG{
public class GUISystem: Form
{
	public static Button start_program=new Button();
	public static Label displaybar=new Label();
	public static Label wonloss_status=new Label();
	public GUISystem ()
	{
		Text="MonsterRPG";
		Size = new Size(800,600);
		CenterToScreen();

		start_program.Location=new Point(0,40);
		start_program.Text="Start Fighting!";
		start_program.Font=new Font("Verdana",9F,System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		start_program.Size=new Size(80,35);
		start_program.Click+=new EventHandler(Exec_Monster.beginfight);

		displaybar.Size=new Size(250,30);
		displaybar.Font=new Font("Verdana",10F,System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

		wonloss_status.Location=new Point(300,0);
		wonloss_status.Size=new Size(400,30);
		wonloss_status.Font=new Font("Verdana",20F,System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		Controls.Add(start_program);
		Controls.Add(displaybar);
		Controls.Add(wonloss_status);
	}
	/*protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
*/
}
}
