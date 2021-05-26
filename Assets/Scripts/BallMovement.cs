using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    float speed = 15f;
    Rigidbody _rgbd;
    // Start is called before the first frame update
    private void Awake()
    {
        _rgbd = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(gameObject.transform.position.y<-4.62f)
        {
            SceneManager.LoadScene(0);    
        }
    }

    public void BallLaunch(Vector3 direction)
    {
        transform.parent = null;                        //the ball is attached to the paddle initially, this function will be called to deattach it and throw it in the air
        _rgbd.velocity = direction.normalized * speed;
    }

}
