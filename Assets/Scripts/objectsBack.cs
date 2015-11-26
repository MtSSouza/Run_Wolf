using UnityEngine;
using System.Collections;

public class objectsBack : MonoBehaviour {

    private bool back;

	// Use this for initialization
	void Start () {
        back = false;
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name.Equals("outColider"))
        {
            back = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.name.Equals("outColider"))
        {
            back = false;
        }
    }

	// Update is called once per frame
	void Update () {

        if (back) {
            this.transform.position = new Vector3(7.54f, -1.38f, 0f);

            if (this.gameObject.name.Equals("Obj01_0"))
            {
                ObjectsSpawner.ob1 = false;
            }

            if (this.gameObject.name.Equals("Obj02_0"))
            {
                ObjectsSpawner.ob2 = false;
            } 

            if (this.gameObject.name.Equals("Obj03_0"))
            {
                ObjectsSpawner.ob3 = false;
            }
            
            if (this.gameObject.name.Equals("Obj06_0"))
            {
                ObjectsSpawner.ob5 = false;
            } 
            
            if (this.gameObject.name.Equals("Obj07_0"))
            {
                ObjectsSpawner.ob6 = false;
            }
            
            if (this.gameObject.name.Equals("Obj09_0"))
            {
                ObjectsSpawner.ob8 = false;
            } 
            
            if (this.gameObject.name.Equals("Obj10_0"))
            {
                ObjectsSpawner.ob9 = false;
            }

        }

	}
}
