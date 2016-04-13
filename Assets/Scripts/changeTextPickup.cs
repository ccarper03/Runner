using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class changeTextPickup : MonoBehaviour 
{
	private Text guitext;
	string basetext;
	private GameControl control;

	// Use this for initialization
	void Start () 
	{
		control = GameObject.FindObjectOfType <GameControl> ();
		guitext = GetComponent<Text> ();
		basetext = guitext.text;
	}
	
	// Update is called once per frame
	void Update () 
	{
		guitext.text = basetext + " " + control.pickups;
	}
}
