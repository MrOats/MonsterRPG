using System;
using Gtk;

namespace MonsterRPG{
public class GUISystem: Window
{
	public static Button start_program=new Button("Begin Fighting!");
	public static Label displaybar=new Label();
	public GUISystem () : base ("MonsterRPG")
	{

		SetDefaultSize(800,600);
		SetPosition(WindowPosition.Center);
		DeleteEvent += new DeleteEventHandler(OnDeleteEvent);
		VBox vbox=new VBox();
		Add(vbox);
		vbox.Add(displaybar);
		vbox.Add(start_program);

		start_program.Clicked+=new EventHandler(Exec_Monster.beginfight);
		ShowAll();
	}
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

}
}
