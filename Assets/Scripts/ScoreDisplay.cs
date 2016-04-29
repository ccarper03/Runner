using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour 
{ 
	public Text guiText;
	public string baseText;
	
	void Start () 
	{
		guiText = GetComponent<Text> ();
		baseText = guiText.text;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//guiText.text = baseText + Mathf.Ceil(GameControl.totalTimeElapsed);
	}
}