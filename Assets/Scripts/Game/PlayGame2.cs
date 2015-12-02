using UnityEngine;
using System.Collections;

public class PlayGame2 : MonoBehaviour {

    private float x;
    private float y;
    private float x2;
    private float y2;
    private float x3;
    private float y3;
    private float x4;
    private float y4;
    private float speed = 1f;
    public GameObject f1;
    public GameObject f2;
    public GameObject f3;
    public GameObject f4;

	// Use this for initialization
	void Awake () {
        x = 0.46f;
        y = 0.46f;
        x2 = 0.16f;
        y2 = 0.16f;
        x3 = 0.05f;
        y3 = 0.05f;
        x4 = 0.03f;
        y4 = 0.03f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        x += speed * Time.deltaTime;
        y += speed * Time.deltaTime;
        x2 += speed * Time.deltaTime;
        y2 += speed * Time.deltaTime;
        x3 += speed * Time.deltaTime;
        y3 += speed * Time.deltaTime;
        x4 += speed * Time.deltaTime;
        y4 += speed * Time.deltaTime;

        f1.gameObject.transform.localScale = new Vector3(x, y, 0f);
        f2.gameObject.transform.localScale = new Vector3(x2, y2, 0f);
        f3.gameObject.transform.localScale = new Vector3(x3, y3, 0f);
        f4.gameObject.transform.localScale = new Vector3(x4, y4, 0f);

        if (f1.gameObject.transform.localScale.x >= 2.8f)
        {
            f1.gameObject.transform.localScale = new Vector3(2.8f, 2.8f, 0f);
        }

        if (f2.gameObject.transform.localScale.x >= 2.8f)
        {
            f2.gameObject.transform.localScale = new Vector3(2.8f, 2.8f, 0f);
        }

        if (f3.gameObject.transform.localScale.x >= 2.8f)
        {
            f3.gameObject.transform.localScale = new Vector3(2.8f, 2.8f, 0f);
        }

        if (f4.gameObject.transform.localScale.x >= 2.8f)
        {
            f4.gameObject.transform.localScale = new Vector3(2.8f, 2.8f, 0f);
        }
	}
}
