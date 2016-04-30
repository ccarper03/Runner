using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour 
{
	public float _startSpeed = -0.4f;
	public float timeExtension = 1.5f;
	public Ground ground;
	public int pickups;
	public Text text;
	public static float timeRemaining = 10;
	public static float totalTimeElapsed = 0;
	public bool isGameOver = false;
	[HideInInspector] public float startSpeed;

	void Awake ()
	{
		startSpeed = _startSpeed;
		pickups = 0;
	}

	// Update is called once per frame
	void Update ()
	{
		if(isGameOver)
		{
			SceneManager.LoadScene("GameOver");;
		}
		
		totalTimeElapsed += Time.deltaTime;
		timeRemaining -= Time.deltaTime * (1 / Time.timeScale);
		
		if(timeRemaining <= 0)
		{
			isGameOver = true;
		}
		else
		{
			_startSpeed -= Time.deltaTime / 50;
			startSpeed = _startSpeed * Time.timeScale;
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

	void SpeedWorldUp ()
	{
		Time.timeScale = 1f;
		ground.Speedup ();
	}

	public void PowerupCollected ()
	{
		timeRemaining += timeExtension;
		pickups++;
	}
}
