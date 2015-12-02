using UnityEngine;
using System.Collections;

public class IntroButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (this.GetComponent<SpriteRenderer>().sprite.name == "Abertura0059" ) { print("ef"); }

	}
}
