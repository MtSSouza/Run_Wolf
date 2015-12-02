using UnityEngine;
using System.Collections;

public class ObjectsMove : MonoBehaviour {

	private float speed = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position -= new Vector3 (speed * Time.deltaTime, 0f, 0f);
		if (this.transform.position.x <= -8) {
			Destroy(this.gameObject);
		}
	}

}
