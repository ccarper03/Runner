using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour 
{
	private GameControl control;
	// Use this for initialization
	void Start () 
	{
		control = GameObject.FindObjectOfType <GameControl> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(0,0,control.startSpeed);
	}
}
