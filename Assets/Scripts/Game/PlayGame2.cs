using UnityEngine;
using System.Collections;

public class PlayGame2 : MonoBehaviour
{

    private float opacityChange;
    private float speed = 2f;
    public GameObject f1;



    // Use this for initialization
    void Start()
    {

        opacityChange = 1f;
        f1.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, opacityChange);
    }

    void FixedUpdate()
    {
            opacityChange -= speed * Time.deltaTime;
            if (opacityChange <= 0)
            {
                opacityChange = 0;
            }
            f1.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, opacityChange);
    }
}
