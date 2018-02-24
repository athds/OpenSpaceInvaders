using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    float speed = 10f;//this one
    public GameObject enemybullet;//this one
    float temptime;
    public Vector3 TargetPosE;//this  one
    bool hitedge; //this
                  // Use this for initialization
    void Start () {
        TargetPosE = enemybullet.transform.position;
        hitedge = false;
        TargetPosE = transform.position + new Vector3(0f,-9f, 0f);


 
    }
	
	// Update is called once per frame
	void Update () {
        Checkbounds();//this

        temptime += Time.deltaTime;
        Debug.Log(temptime);
        if (temptime > 1)
        {

            temptime = 0;
            TargetPosE =new Vector3(enemybullet.transform.position.x, -9f, 0f); //this one

        }
        

        float MoveStep = speed * Time.deltaTime; //this one
        enemybullet.transform.position = Vector3.MoveTowards(enemybullet.transform.position, TargetPosE, MoveStep); //this one


    }
    void Checkbounds() //this function
    {
        if (enemybullet.transform.position.y <= -4.9f)
        {
            enemybullet.transform.position = transform.position;
            TargetPosE = enemybullet.transform.position;
            hitedge = true;

        }
    }
}
