using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemyMissle : MonoBehaviour {

	public Text Scoretext2;
    int score = 0;
    public GameObject player;
    public GameObject loser;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Scoretext2.text = score.ToString();

	}

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            //Do more reseting here
        	loser.SetActive(true);
        	Player.SetActive(false);
            score = 0;

        }
        

    }
}
