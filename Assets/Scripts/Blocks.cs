using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blocks : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(BlocksDown());
    }

    private void Update()
    {
        if(gameObject.transform.childCount==0)   //to check whether all blocks have been destroyed or not
        {                                       // if destroyed, it will load to 2nd level
            SceneManager.LoadScene(1);              //to load next scene
        }

        if(gameObject.transform.position.y<=-7)
        {
            SceneManager.LoadScene(0);              //if blocks reached to the bottom of the game, the game will restart itslef
        }
    }
    IEnumerator BlocksDown()
    {
        yield return new WaitForSeconds(5f);
        gameObject.transform.position -= new Vector3(0, 1, 0);             //to decrease the position of blocks in y axis by 1 m after 5 seconds
        StartCoroutine(TimeDown());
    }

    IEnumerator TimeDown()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            gameObject.transform.position -= new Vector3(0, 1, 0);     //to decrease the position of blocks in y axis by 1 m after every 3 seconds
        }
    }
}
