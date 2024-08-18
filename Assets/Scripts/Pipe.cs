using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float moveSpeed = 5f;
   
   

    private void Start()
    {
        Debug.Log("string 4");
    }

    private void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;    
        if(transform.position.x < -40)
        {
            Destroy(this.gameObject);
        }
    }

    

   

}

