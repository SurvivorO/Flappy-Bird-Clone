using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
   
    private Player_Bird birdScript;

    private void Start()
    {
        birdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<Player_Bird>();
    }


    private void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        birdScript.AddScore();
        
    }
}
