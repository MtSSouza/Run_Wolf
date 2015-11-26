using UnityEngine;
using System.Collections;

public class ObjectsSpawner : MonoBehaviour {

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj8;
    public GameObject obj9;

    public static bool ob1 = false;
    public static bool ob2 = false;
    public static bool ob3 = false;
    public static bool ob5 = false;
    public static bool ob6 = false;
    public static bool ob8 = false;
    public static bool ob9 = false;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        obj1Spawn();
        obj2Spawn();
        obj3Spawn();
        obj5Spawn();
        obj6Spawn();
        obj8Spawn();
        obj9Spawn();

        if (ObjectsTimer.randomObject == 1)
        {
            ob1 = true;
        }

        if (ObjectsTimer.randomObject == 2)
        {
            ob2 = true;
        }

        if (ObjectsTimer.randomObject == 3)
        {
            ob3 = true;
        }

        if (ObjectsTimer.randomObject == 4)
        {
            ob5 = true;
        }

        if (ObjectsTimer.randomObject == 5)
        {
            ob6 = true;
        }

        if (ObjectsTimer.randomObject == 6)
        {
            ob8 = true;
        }

        if (ObjectsTimer.randomObject == 7)
        {
            ob9 = true;
        }

	}

    void obj1Spawn(){
        if (ob1)
        {
            obj1.gameObject.SetActive(true);
            obj1.transform.position -= new Vector3(3f * Time.deltaTime, 0f, 0f);
        }
       
    }

    void obj2Spawn()
    {
        if (ob2)
        {
            obj2.gameObject.SetActive(true);
            obj2.transform.position -= new Vector3(3f * Time.deltaTime, 0f, 0f);
        }
    }

    void obj3Spawn()
    {
        if (ob3)
        {
            obj3.gameObject.SetActive(true);
            obj3.transform.position -= new Vector3(3f * Time.deltaTime, 0f, 0f);
        }
    }

    void obj5Spawn()
    {
        if (ob5)
        {
            obj5.gameObject.SetActive(true);
            obj5.transform.position -= new Vector3(3f * Time.deltaTime, 0f, 0f);
        }
    }
    void obj6Spawn()
    {
        if (ob6)
        {
            obj6.gameObject.SetActive(true);
            obj6.transform.position -= new Vector3(3f * Time.deltaTime, 0f, 0f);
        }
    }
    void obj8Spawn()
    {
        if (ob8)
        {
            obj8.gameObject.SetActive(true);
            obj8.transform.position -= new Vector3(3f * Time.deltaTime, 0f, 0f);
        }
    }
    void obj9Spawn()
    {
        if (ob9)
        {
            obj9.gameObject.SetActive(true);
            obj9.transform.position -= new Vector3(3f * Time.deltaTime, 0f, 0f);
        }
    }
}
