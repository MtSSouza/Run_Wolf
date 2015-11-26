using UnityEngine;
using System.Collections;

public class ObjectsTimer : MonoBehaviour {

    private float timerSpawnObject = 3.0f;
    public static int randomObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        timerSpawnObject -= Time.deltaTime;
        if (timerSpawnObject <= 0)
        {
            timerSpawnObject = Random.Range(5, 10);
            randomObject = Random.Range(0, 8);
        }
     
            print(timerSpawnObject + " / " + randomObject);
	}
}
