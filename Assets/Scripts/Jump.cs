using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	
	private bool flyOk;
	
	void OnCollisionStay2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Platform") 
		{
			flyOk = true;
			this.GetComponent<Animator>().SetBool("toJump", false);
		}
	}
	void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Platform") 
		{
			flyOk = false;
			this.GetComponent<Animator>().SetBool("toJump", true);
		}
	}

	void Pulo()
	{
		
		if (Input.touchSupported) {
			if(Input.GetMouseButton(0))
			{
				this.rigidbody2D.AddForce(Vector3.up * 200f);
			}
		}
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			this.rigidbody2D.AddForce(Vector3.up * 200f);
		}

	}
	
	void Update () 
	{

		if (flyOk) 
		{
			Pulo ();
		}

	}
}
