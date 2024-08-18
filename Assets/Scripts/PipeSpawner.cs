using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]private GameObject pipePrefab;
    [SerializeField] private float interval = 2.0f;

    private float minPositionY = -2.0f;
    private float maxPositionY = 1.5f;
    private float timer = 0;
    

    private Vector3 pipeSpawnPosition;

    private void Start()
    {
        Debug.Log("string 3");
    }

    private void Update()
    {
        pipeSpawnPosition = new Vector3(transform.position.x, Random.Range(minPositionY, maxPositionY), 0);

        timer += Time.deltaTime;
        if (timer > interval)
        {
            Spawner();
            timer -= interval;
        }

    }
    private void Spawner()
    {
        
        GameObject newGameObjectToSpawn = Instantiate(pipePrefab, pipeSpawnPosition, Quaternion.identity);
        
        
    }

   
}
