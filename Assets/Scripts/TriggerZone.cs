using UnityEngine;
using System.Collections;

public class TriggerZone : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);
		if(other.gameObject.tag == "Player")
		{
			Debug.Log ("Player has died.");
		}
	}
}
