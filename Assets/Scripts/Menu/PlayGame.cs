using UnityEngine;
using System.Collections;

public class PlayGame : MonoBehaviour {

    private bool startAll;
    private bool nextFase;
    private float x;
    private float y;
    private float speed = 4f;
    public GameObject f1;
    public GameObject f2;
    public GameObject f3;
    public GameObject f4;


	// Use this for initialization
	void Start () {
        startAll = false;
        nextFase = false;
        x = 2.864501f;
        y = 2.864501f;
	}

    void OnMouseDown()
    {
        startAll = true;
    }

	void Update () {

        if (startAll)
        {
            x -= speed * Time.deltaTime;
            y -= speed * Time.deltaTime;

            f1.gameObject.transform.localScale = new Vector3(x, y, 0f);
            f2.gameObject.transform.localScale = new Vector3(x, y, 0f);
            f3.gameObject.transform.localScale = new Vector3(x, y, 0f);
            f4.gameObject.transform.localScale = new Vector3(x, y, 0f);

            if (f1.gameObject.transform.localScale.x <= 0.46f) {
                f1.gameObject.transform.localScale = new Vector3(0.46f, 0.46f, 0f);
            }

            if (f2.gameObject.transform.localScale.x <= 0.16f)
            {
                f2.gameObject.transform.localScale = new Vector3(0.16f, 0.16f, 0f);
            }

            if (f3.gameObject.transform.localScale.x <= 0.05f)
            {
                f3.gameObject.transform.localScale = new Vector3(0.05f, 0.05f, 0f);
            }

            if (f4.gameObject.transform.localScale.x <= 0.03f)
            {
                f4.gameObject.transform.localScale = new Vector3(0.03f, 0.03f, 0f);
                nextFase = true;
            }
        }

        if (nextFase) {
            //Application.LoadLevel(1);
        }
	}
}
