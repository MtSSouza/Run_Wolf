using UnityEngine;
using System.Collections;

public class PlayGame : MonoBehaviour {

    private bool startAll;
    private bool nextFase;
    private float opacityChange;
    private float speed = 2f;
    public GameObject f1;



	// Use this for initialization
	void Start () {
        startAll = false;
        nextFase = false;
        opacityChange = 0f;
        f1.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, opacityChange);
	}

    void OnMouseDown()
    {
        startAll = true;
    }

	void FixedUpdate () {

        if (startAll)
        {
            opacityChange += speed * Time.deltaTime;
            if (opacityChange >= 1)
            {
                opacityChange = 1;
                nextFase = true;
            }
            f1.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, opacityChange);
        }

        if (nextFase) {
            Application.LoadLevel(1);
        }
	}
}
