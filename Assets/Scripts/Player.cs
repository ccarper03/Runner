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
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Powerup(Clone)") 
		{
			control.PowerupCollected ();
		} 
		else if(other.gameObject.name == "Obstacle(Clone)" && !jumping) 
		{
			control.slowWorldDown ();

		}
		if(other.gameObject.tag == "Destructable")
		{
			Destroy (other.gameObject);
			//some comments
			// more comments
		}
	}

	void JumpFinish()
	{
		jumping = false;
	}
}
