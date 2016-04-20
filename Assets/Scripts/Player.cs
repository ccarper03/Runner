using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public GameControl control;
	private Animator anim;
	private Rigidbody body;
	public float strafeSpeed = 4f;
	private bool jumping = false;
	private int count; 

	void Start()
	{
		anim = GetComponent<Animator> ();
		body = GetComponent<Rigidbody> ();
	}

	void Update () 
	{
		float xMove = Input.GetAxis ("Horizontal") * Time.deltaTime * strafeSpeed;
		transform.Translate (xMove, 0f, 0f);

		if(transform.position.x > 3)
		{
			//transform.Translate (3f, 0f, 0f);	
		} 
		else if(transform.position.x < -3)
		{
			//transform.Translate (-3f, 0f, 0f);
		}
		if(Input.GetButtonDown("Jump") && !jumping)
		{
			anim.SetTrigger ("Jump");
			body.AddForce (Vector3.up * 250);
			Debug.Log (Vector3.up);
			jumping = true;
		}

		if (control.isGameOver)
			Destroy(gameObject);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp") 
		{
			control.PowerupCollected ();
			other.GetComponent<AudioSource>().Play ();
			other.GetComponent<MeshRenderer>().enabled = false;
			// Destroy (other.gameObject);
		} 

		if(other.gameObject.tag == "Obstacle") 
		{
			control.slowWorldDown ();
			other.GetComponent<AudioSource>().Play ();
			other.GetComponent<MeshRenderer>().enabled = false;
			// Destroy (other.gameObject);
		}
	}

	void JumpFinish()
	{
		jumping = false;
	}
}
