using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour 
{
	public float startSpeed = -0.4f;
	public float timeExtension = 1.5f; 
	public Ground ground;
	public int pickups = 0;

	private float timeRemaining = 10;
	private float totalTimeElapsed = 0;
	private bool isGameOver = false;

	// Update is called once per frame
	void Update () 
	{
		if(isGameOver)
		{
			return;
		}

		totalTimeElapsed += Time.deltaTime;
		timeRemaining -= Time.deltaTime;
		if(timeRemaining <= 0)
		{
			isGameOver = true;
		}
	}
	/// Slows the world down.
	public void slowWorldDown ()
	{
		CancelInvoke ("SpeedWorldUp"); // will cancel any commands that speeds the world up. 
		ground.slowdown(); // calls slowdown function
		Invoke("SpeedWorldUp",1); //Speed the world up after 1 second; 
		Time.timeScale = 0.5f;
	}

	void SpeedWorldUp()
	{
		Time.timeScale = 1f;
		ground.Speedup ();
	}

	public void PowerupCollected() 
	{
		timeRemaining += timeExtension;
		pickups++;
	}

	/// Using Unity's old lagacy GUI system fix later to the updated method later///
	void onGUI()
	{
		if (!isGameOver) 
		{
			Rect boxRect = new Rect (Screen.width / 2 - 50, Screen.height -100, 100, 50);
			GUI.Box (boxRect, "Time Remaining");
			Rect labelRect = new Rect (Screen.width / 2 - 10, Screen.height - 80, 20, 40);
			GUI.Label (labelRect, ((int)timeRemaining).ToString ());
		} 
		else 
		{
			Rect boxRect = new Rect (Screen.width / 2 - 60, Screen.height / 2 - 100, 120, 50);
			GUI.Box (boxRect, "GameOver");

			Rect labelRect = new Rect (Screen.width / 2 - 55, Screen.height / 2 - 80, 90, 40);
			GUI.Box (labelRect, "Total Time: " + (int)totalTimeElapsed);

			Time.timeScale = 0; 
		}
	}
}
