using UnityEngine;
using System.Collections;
using System;

public class GhostAI : MonoBehaviour {

	StateMachine<GhostAI> _fsm;
	public StateMachine<GhostAI> getFSM()
	{
		return _fsm;
	}

	// each state can subscribe to these events
	public event EventHandler attackWaveEvent;
	public event EventHandler finishAttackWaveEvent;
	public event EventHandler poweredPacManEvent;
	public event EventHandler notPoweredPacManEvent;
	public event EventHandler gotHomeEvent;
	public event EventHandler eatenEvent;

	void Start()
	{
		_fsm = new StateMachine<GhostAI>(this);
		_fsm.setState(new ScatterState());
	}
	
	void Update () 
	{
		//TO-DO: launch a coroutine that executes each x seconds
		_fsm.AIupdate();
	}

	// Actions to be used by the states
	public void reverseDirection()
	{
		Debug.Log("direction reverted");
	}
	public void moveToHomeCorner()
	{
		Debug.Log("moved to home corner");
	}
		
	// events
	public void attackWaveReceived()
	{
		//Debug.Log("attack wave event received");
		attackWaveEvent.Invoke(this, null);
	}
	public void finishAttackWaveReceived()
	{
		//Debug.Log("attack wave event received");
		finishAttackWaveEvent.Invoke(this, null);
	}
	public void poweredPacManReceived()
	{
		//Debug.Log("pac-man powered event received");
		poweredPacManEvent.Invoke(this, null);
	}
	public void notPoweredPacManReceived()
	{
		//Debug.Log("pac-man powered event received");
		notPoweredPacManEvent.Invoke(this, null);
	}
	public void eatenReceived()
	{
		//Debug.Log("got home event received");
		eatenEvent.Invoke(this, null);
	}
	public void gotHomeReceived()
	{
		//Debug.Log("got home event received");
		gotHomeEvent.Invoke(this, null);
	}
}
