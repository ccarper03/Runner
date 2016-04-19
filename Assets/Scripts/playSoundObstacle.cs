using UnityEngine;
using System.Collections;

public class playSoundObstacle : MonoBehaviour 
{
	public AudioClip myClip;
	public AudioSource source;

	void Awake () {

		source = GetComponent<AudioSource>();
	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			GetComponent<AudioSource>().Play ();
		} 
	}
}