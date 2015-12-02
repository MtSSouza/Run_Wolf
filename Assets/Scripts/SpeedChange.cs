using UnityEngine;
using System.Collections;

public class SpeedChange : MonoBehaviour {

    private float speed = 0.01f;
    private float speedRun;
    private float speedNow;

	// Use this for initialization
	void Start () {
        speedNow = 1;
	}
	
	// Update is called once per frame
	void Update () {

        if (this.GetComponent<Animator>().GetBool("toJump") == true)
        {
            this.GetComponent<Animator>().speed = 0.8f;
        }
        else
        {
            this.GetComponent<Animator>().speed = speedNow;
            this.GetComponent<Animator>().speed += speedRun;
        }


        speedRun = speed * Time.deltaTime;
        print(this.GetComponent<Animator>().speed);

	}
}
