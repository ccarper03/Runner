using UnityEngine;
using UnityEngine.UI;

public class HUDPickups : MonoBehaviour
{
	public static GameControl control;
	private Text guiText;
	private string baseText;

	void Awake()
	{
		control = GameObject.FindObjectOfType<GameControl>();
		guiText = GetComponent<Text>();
		baseText = guiText.text;
	}

	void Update()
	{
		guiText.text = baseText + " " + control.pickups;
	}
}
