using UnityEngine;
using System.Collections;

public class SchoollingParallax : MonoBehaviour {

	public float speed = 0f;

	// Use this for initialization
	void Start () {

		// 1.1 - ir 112.8 || ch -46.6
		// 2 -  89.6 || -39
		// 1 -  112.1 || -41.3
		// 3 -  82.1 || -20.4
		// 4 -  55.47 || -20.8
	}

	void Update (){
		if (this.transform.name.Equals ("Parallax1") && this.transform.position.x <= -41.3f) {
			transform.position = new Vector2(112.1f, -0.63f);
		}

		if (this.transform.name.Equals ("Parallax1(2)") && this.transform.position.x <= -41.3f) {
			transform.position = new Vector2(112.1f, -0.63f);
		}		

		if (this.transform.name.Equals ("Parallax1.1") && this.transform.position.x <= -46.6f) {
			transform.position = new Vector2(112.8f, -0.27f);
		}
		
		if (this.transform.name.Equals ("Parallax1.1(2)") && this.transform.position.x <= -46.6f) {
			transform.position = new Vector2(112.8f, -0.27f);
		}

		if (this.transform.name.Equals ("Parallax2") && this.transform.position.x <= -39f) {
			transform.position = new Vector2(89.61f, -0.2f);
		}
		
		if (this.transform.name.Equals ("Parallax2(2)") && this.transform.position.x <= -39f) {
			transform.position = new Vector2(89.6f, -0.2f);
		}

		if (this.transform.name.Equals ("Parallax3") && this.transform.position.x <= -20.4f) {
			transform.position = new Vector2(82.1f, 0.1f);
		}
		
		if (this.transform.name.Equals ("Parallax3(2)") && this.transform.position.x <= -20.4f) {
			transform.position = new Vector2(82.1f, 0.1f);
		}

		if (this.transform.name.Equals ("Parallax4") && this.transform.position.x <= -20.8f) {
			transform.position = new Vector2(55.47f, 1.9f);
		}
		
		if (this.transform.name.Equals ("Parallax4(2)") && this.transform.position.x <= -20.8f) {
			transform.position = new Vector2(55.47f, 1.9f);
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (this.transform.name.Equals ("Parallax1")) {
			speed = 3f;
			this.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
		}

		else if (this.transform.name.Equals ("Parallax1.1")) {
			speed = 1f;
			this.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
		}

		else if (this.transform.name.Equals ("Parallax2")) {
			speed = 0.5f;
			this.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
		}

		else if (this.transform.name.Equals ("Parallax3")) {
			speed = 0.3f;
			this.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
		}

		else if (this.transform.name.Equals ("Parallax4")) {
			speed = 0.1f;
			this.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
		}

		else if (this.transform.name.Equals ("Lua")) {
			speed = 0.05f;
			this.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
		}
		//
		//// Parallax
		//
		if (this.transform.name.Equals ("Parallax1(2)")) {
			speed = 3f;
			this.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
		}
		
		else if (this.transform.name.Equals ("Parallax1.1(2)")) {
			speed = 1f;
			this.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
		}
		
		else if (this.transform.name.Equals ("Parallax2(2)")) {
			speed = 0.5f;
			this.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
		}
		
		else if (this.transform.name.Equals ("Parallax3(2)")) {
			speed = 0.3f;
			this.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
		}
		
		else if (this.transform.name.Equals ("Parallax4(2)")) {
			speed = 0.1f;
			this.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
		}
		

	}
}
