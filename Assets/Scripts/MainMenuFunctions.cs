using UnityEngine;
using System.Collections;

public class MainMenuFunctions : MonoBehaviour 
{
	public void BtnPlayClick()
	{
		Application.LoadLevel("Main");
	}
//	public void BtnOptionsClick()
//	{
//		gameObject.SetActive(false);
//	}
//	public void BtnCreditsClick()
//	{
//		Application.LoadLevel("GetButton and GetKey");
//
//	}
	public void BtnExitClick()
	{
		//Application.Quit ();
		Debug.Log("You have Quit the program");
	}
//	public void BTN_Ctr()
//	{
//		Debug.Log("Controls");
//	}
//	public void BTN_SFX()
//	{
//		Debug.Log("Sound Effects");
//	}
//	public void BTN_ScM()
//	{
//		Debug.Log("Social Media");
//	}
//	public void BTN_Bck()
//	{
//		Debug.Log("Back");
//	}
//	public void BTN_Msc()
//	{
//		Debug.Log("Music");
//	}
}
