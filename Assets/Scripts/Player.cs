using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public GameControl control;
	private Animator anim;
	public float strafeSpeed = 4f;
	private bool jumping = false;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	void Update () 
	{
		float xMove = Input.GetAxis ("Horizontal") * Time.deltaTime * strafeSpeed;
		transform.Translate (xMove, 0f, 0f);

		if(transform.position.x > 3)
		{
			transform.Translate (3f, 0f, 0f);	
		} 
		else if(transform.position.x < -3)
		{
			transform.Translate (-3f, 0f, 0f);
		}
		if(Input.GetButtonDown("Jump"))
		{
			anim.SetTrigger ("Jump");
		}
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Run")) 
		{
			jumping = false;
		} 
		else 
		{
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
		}
	}
}
