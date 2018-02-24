using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missles : MonoBehaviour {


    public Text Scoretext;
    public int score = 0;
    public GameObject drone1;
    public GameObject drone2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Scoretext.text = score.ToString();

	}

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            drone1.SetActive(false);

            score += 1;

        }
        if (collision.gameObject.tag == "enemy1")
        {
            drone2.SetActive(false);

            score += 1;

        }

    }
}
