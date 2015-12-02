using UnityEngine;
using System.Collections;

public class IntroButton : MonoBehaviour {

    public GameObject spr;
    private float opacityChange;
    private float speed = 0.55f;
	// Use this for initialization
	void Start () {
        opacityChange = 0f;
        spr.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, opacityChange);
	}
	

	// Update is called once per frame
	void Update () {

        if (this.GetComponent<SpriteRenderer>().sprite.name == "Abertura0059" )
        {
            opacityChange += speed * Time.deltaTime;
            if (opacityChange >= 1)
            {
                opacityChange = 1;
            }
            spr.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, opacityChange);
        }

	}
}
