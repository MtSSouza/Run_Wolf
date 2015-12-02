using UnityEngine;
using System.Collections;

public class TriggerFind : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag.Equals ("Objects")) {
			print("pqp");
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
