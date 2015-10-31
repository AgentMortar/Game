using UnityEngine;
using System.Collections;

public class PlayerController2d : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;

	void Start () {

	}
		
	void Update ()
	{


		if (Input.GetKeyDown (KeyCode.Space))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
		}
			

		if(Input.GetKey (KeyCode.D))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		if(Input.GetKey (KeyCode.A))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
	  }
		
	}
}