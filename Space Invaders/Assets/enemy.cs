using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    float speed = 10f;//this one
    public GameObject enemybullet;//this one
    float temptime;
    Vector3 TargetPos;//this  one
    bool hitedge; //this
                  // Use this for initialization
    void Start () {
        TargetPos = enemybullet.transform.position;
        hitedge = false;
        TargetPos = transform.position + new Vector3(0f,-9f, 0f);



    }
	
	// Update is called once per frame
	void Update () {
        Checkbounds();//this

        temptime += Time.deltaTime;
        Debug.Log(temptime);
        if (temptime > 1)
        {

            temptime = 0;
            TargetPos = transform.position + new Vector3(0f, -9f, 0f); //this one

        }
        if (hitedge == true)
        {

            TargetPos = transform.position;

        }

        float MoveStep = speed * Time.deltaTime; //this one
        enemybullet.transform.position = Vector3.MoveTowards(enemybullet.transform.position, TargetPos, MoveStep); //this one


    }
    void Checkbounds() //this function
    {
        if (enemybullet.transform.position.y <= -4.9f)
        {
            enemybullet.transform.position = transform.position;

            hitedge = true;

        }
    }
}
