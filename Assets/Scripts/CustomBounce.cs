using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBounce : MonoBehaviour
{
    BoxCollider box;

    private void Awake()
    {
        box = GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Ball")
        {
            float relativePos = (other.transform.position.x - transform.position.x)/box.bounds.size.x;    //to calculate the relative postion of the point where the ball strikes the paddle
            other.rigidbody.velocity = new Vector3(relativePos, 1, 0).normalized * other.rigidbody.velocity.magnitude;
            //to determine the velocity of the ball and throw it away with same magnitude but in normlized way
        }
    }
}
