using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
	public void start()
	{
		SceneManager.LoadScene("Main");
	}
	public void Options()
	{
		SceneManager.LoadScene("Options");
	}
	public void Credits()
	{
		SceneManager.LoadScene("Credits");
	}

	public void Mainmenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void Gameover()
	{
		SceneManager.LoadScene("GameOver");
	}

	public void Exit()
	{
		Debug.Log ("End of Program");
	}

}
// SceneManager.LoadScene("GameOver");