using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	public float speed = .5f;
	private Renderer groundrenderer;

	// Use this for initialization
	void Start () 
	{
		groundrenderer = GetComponent<Renderer> ();
	}
	void Update ()
	{
		float offset = Time.time * speed % 1;  // % 1 keeps offset between 0 and 1 
		groundrenderer.material.mainTextureOffset = new Vector2(0, -offset);
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
