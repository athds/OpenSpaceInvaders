using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {


    public float speed = 10f;
    public GameObject leftBullet;
    public Vector3 TargetPos;
    bool hitedge;
	// Use this for initialization
	void Start () {
        TargetPos = leftBullet.transform.position;

        hitedge = false;

	}
	
	// Update is called once per frame
	void Update () {
        CheckInput();


        Checkbounds();


        float MoveStep = speed * Time.deltaTime;
        leftBullet.transform.position = Vector3.MoveTowards(leftBullet.transform.position, TargetPos, MoveStep);
	}


    void CheckInput()
    {
         
        if (Input.GetKey("space")){
            leftBullet.SetActive(true);
            TargetPos = transform.position + new Vector3(0f, 9f, 0f);
            hitedge = false;
        }
        else
        {
            if(hitedge == true)
            {

                TargetPos = transform.position;

            }
            
        }
         transform.Translate(Vector3.left * Input.GetAxis("Horizontal") * -speed * Time.deltaTime);

    }

    void Checkbounds()
    {
        if(leftBullet.transform.position.y == 5.27f)
        {
            leftBullet.transform.position = transform.position;

            hitedge = true;

        }
    }
}
