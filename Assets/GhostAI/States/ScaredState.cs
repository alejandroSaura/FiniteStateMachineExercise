using UnityEngine;
using System.Collections;
using System;

public class ScaredState : GhostAIState 
{	

	public override void enter (GhostAI ghost)
	{
		Debug.Log("State enter executed....");
		Debug.Log("Scared State");

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
	public override void eatenReceived(System.Object sender, EventArgs args)
	{
		Debug.Log("attack wave event received on child");
		StateMachine<GhostAI> fsm = ((GhostAI)sender).getFSM();
		fsm.setState(new GoHomeState());
	}
	public override void notPoweredPacManReceived(System.Object sender, EventArgs args)
	{
		Debug.Log("attack wave event received on child");
		StateMachine<GhostAI> fsm = ((GhostAI)sender).getFSM();
		fsm.setState(new ScatterState());
	}
}
