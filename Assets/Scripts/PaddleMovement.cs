using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    private float speed = 20f;
    Vector3 launchDirection = new Vector3(1, 4, 0);  //to launch the ball initially in the given direction
    void Start()
    {
        
    }
    
    void Update()
    {
        var hInput = Input.GetAxis("Horizontal"); //direct way to use A and D as input 
        gameObject.transform.Translate(new Vector3(hInput, 0, 0)*speed*Time.deltaTime);   //used time.deltatime bcoz by default it will run wrt frames
        gameObject.transform.position=new Vector3(Mathf.Clamp(gameObject.transform.position.x, -5.19f, 5.38f),-4.22f,0); //to clamp the paddle in x axis

        if(transform.childCount>0 && Input.GetButtonDown("Jump"))
        {
            BallMovement ball = GetComponentInChildren<BallMovement>();
            ball.BallLaunch(launchDirection); // called the function from ball movement script
        }

        

    }
    
}
