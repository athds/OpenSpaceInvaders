using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {


    public float speed = 10f;//this one
    public GameObject leftBullet;//this one
    public Vector3 TargetPos;//this  one
    bool hitedge; //this
	// Use this for initialization
	void Start () {
        TargetPos = leftBullet.transform.position;//this

        hitedge = false;//this

	}
	
	// Update is called once per frame
	void Update () {
        CheckInput();


        Checkbounds();//this


        float MoveStep = speed * Time.deltaTime; //this one
        leftBullet.transform.position = Vector3.MoveTowards(leftBullet.transform.position, TargetPos, MoveStep); //this one
	}


    void CheckInput()
    {
         
        if (Input.GetKey("space")){
            leftBullet.SetActive(true);
            TargetPos = transform.position + new Vector3(0f, 9f, 0f); //this one
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

    void Checkbounds() //this function
    {
        if(leftBullet.transform.position.y == 5.27f)
        {
            leftBullet.transform.position = transform.position;

            hitedge = true;

        }
    }
}
