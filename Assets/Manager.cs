using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	GhostAI ghostAI;

	void Start () 
	{
		ghostAI = GameObject.Find("Ghost").GetComponent<GhostAI>();
	}
	
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.A)) ghostAI.attackWaveReceived();
		if (Input.GetKeyDown(KeyCode.B)) ghostAI.finishAttackWaveReceived();
		if (Input.GetKeyDown(KeyCode.C)) ghostAI.poweredPacManReceived();
		if (Input.GetKeyDown(KeyCode.D)) ghostAI.notPoweredPacManReceived();
		if (Input.GetKeyDown(KeyCode.F)) ghostAI.eatenReceived();
		if (Input.GetKeyDown(KeyCode.G)) ghostAI.gotHomeReceived();

	}
}
