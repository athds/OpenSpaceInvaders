using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missles : MonoBehaviour {



    public GameObject drone1;
    public GameObject drone2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            drone1.SetActive(false);
        }
        if (collision.gameObject.tag == "enemy1")
        {
            drone2.SetActive(false);
        }

    }
}
