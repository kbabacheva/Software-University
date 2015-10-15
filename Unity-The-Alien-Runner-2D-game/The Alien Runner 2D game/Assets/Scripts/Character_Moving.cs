using UnityEngine;
using System.Collections;

public class Character_Moving : MonoBehaviour 
{
	public float maxSpeed;
	public float jumpHeight;
	public float doubleJumpHeight;
	bool grounded;
	bool doubleJump;
	bool jumped;
	float jumpTime, jumpDelay = .5f;
	Animator anim;
	
	void Start ()		
	{
		anim = GetComponent<Animator> ();
	}
	void FixedUpdate ()
	{
		rigidbody2D.velocity = new Vector2 (maxSpeed, rigidbody2D.velocity.y);
		
		if ((Input.GetKeyDown (KeyCode.Space) && grounded == true)||
		    (Input.GetKeyDown (KeyCode.Space) && doubleJump == false)) 			
		{	
			if(Input.GetKeyDown (KeyCode.Space) && grounded == false && jumped == true)
			{
				//rigidbody2D.AddForce(Vector2.up * jumpHeight);
				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,doubleJumpHeight);
				anim.SetTrigger("doubleJump");
				doubleJump = true;
				jumpTime = jumpDelay;
				
			}
			if(Input.GetKeyDown (KeyCode.Space) && grounded == true && jumped == false)
			{
				rigidbody2D.AddForce(Vector2.up * jumpHeight);
				anim.SetTrigger("Jumping");
				jumpTime = jumpDelay;
				jumped = true;
				grounded = false;
			}
		}
		jumpTime -= Time.deltaTime;
		if(grounded == true && jumpTime <= 0 && jumped == true)
		{
			anim.SetTrigger("Landing");
			jumped = false;
		}
	}
	
	
	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Ground")
		{
			grounded = true;
			doubleJump = false;
			
		}
		else
		{
			grounded = false;
		}
		
	}
}
