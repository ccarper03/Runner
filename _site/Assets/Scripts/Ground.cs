using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {
	private GameControl control;

	public float speed = .5f;
	//private Renderer groundrenderer;
	float offset = 0f; 

	// Use this for initialization
	void Start () 
	{
		control = GameObject.FindObjectOfType <GameControl> ();
	//	groundrenderer = GetComponent<Renderer> ();
	}
	void Update ()
	{
		transform.Translate(0,0,control.startSpeed);

		if(transform.localPosition.z < -25.24f)
		{
			transform.Translate (0, 0, 149.87f);
		}
		
//		offset = (offset + Time.deltaTime * speed) % 1;  // % 1 keeps offset between 0 and 1 
//		groundrenderer.material.mainTextureOffset = new Vector2(0, -offset);
	}
	public void slowdown()
	{
		speed = speed / 2;
	}
	public void Speedup()
	{
		speed = speed * 3;
	}
}
