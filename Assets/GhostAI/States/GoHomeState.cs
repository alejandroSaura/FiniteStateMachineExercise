using UnityEngine;
using System.Collections;
using System;

public class GoHomeState : GhostAIState 
{	

	public override void enter (GhostAI ghost)
	{
		Debug.Log("State enter executed....");
		Debug.Log("GoHome State");

		base.enter(ghost);
	}

	public override void execute (GhostAI ghost)
	{

	}

	public override void exit (GhostAI ghost)
	{
		Debug.Log("....State exit executed");
		base.exit(ghost);
	}

	// events
	public override void gotHomeReceived(System.Object sender, EventArgs args)
	{
		Debug.Log("attack wave event received on child");
		StateMachine<GhostAI> fsm = ((GhostAI)sender).getFSM();
		fsm.setState(new ScatterState());
	}
}
