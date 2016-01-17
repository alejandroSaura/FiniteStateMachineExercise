using UnityEngine;
using System.Collections;
using System;

public class GhostAIState : AIState<GhostAI> 
{	

	#region AIState implementation
	public virtual void enter (GhostAI ghost)
	{
		// subscribe the events
		ghost.attackWaveEvent += attackWaveReceived;
		ghost.poweredPacManEvent += poweredPacManReceived;
		ghost.gotHomeEvent += gotHomeReceived;
		ghost.notPoweredPacManEvent += notPoweredPacManReceived;
		ghost.finishAttackWaveEvent += finishAttackWaveReceived;
		ghost.eatenEvent += eatenReceived;
	}

	public virtual void execute (GhostAI ghost)
	{

	}

	public virtual void exit (GhostAI ghost)
	{
		// Clear the events
		ghost.attackWaveEvent -= attackWaveReceived;
		ghost.poweredPacManEvent -= poweredPacManReceived;
		ghost.gotHomeEvent -= gotHomeReceived;
		ghost.notPoweredPacManEvent -= notPoweredPacManReceived;
		ghost.finishAttackWaveEvent -= finishAttackWaveReceived;
		ghost.eatenEvent -= eatenReceived;
	}
	#endregion


	// events
	public virtual void attackWaveReceived(System.Object sender, EventArgs args)
	{
		Debug.Log("attack wave event received in father");
	}
	public virtual void finishAttackWaveReceived(System.Object sender, EventArgs args)
	{
		Debug.Log("attack wave event received in father");
	}
	public virtual void poweredPacManReceived(System.Object sender, EventArgs args)
	{
		Debug.Log("pac-man powered event received in father");
	}
	public virtual void notPoweredPacManReceived(System.Object sender, EventArgs args)
	{
		Debug.Log("pac-man not powered event received in father");
	}
	public virtual void eatenReceived(System.Object sender, EventArgs args)
	{
		Debug.Log("eaten event received in father");
	}
	public virtual void gotHomeReceived(System.Object sender, EventArgs args)
	{
		Debug.Log("got home event received in father");
	}
}

