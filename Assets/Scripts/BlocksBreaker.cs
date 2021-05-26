using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksBreaker : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Block")
        {
            Destroy(other.gameObject);             // this script is attached to the ball. The blacks have tageed as Block, whenever the block
        }                                            //   collides with the ball, the block will be destroyed 
    }
}
