using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] esqueletoPrefabs;
    private float spawnDelay = 6f;
    private float spawnRangeX = 10f;
    private float spawnRangeZ = 10f; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEsqueleto", 0f, spawnDelay); 
    }

    void SpawnEsqueleto()
    {
        int esqueletoIndex = Random.Range(0, esqueletoPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));

        Instantiate(esqueletoPrefabs[esqueletoIndex], spawnPos, esqueletoPrefabs[esqueletoIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.S)){
            int esqueletoIndex = Random.Range(0, esqueletoPrefabs.Length);
            Instantiate(esqueletoPrefabs[esqueletoIndex], new Vector3(5, 0, -10),
                esqueletoPrefabs[esqueletoIndex].transform.rotation);

        }  
    }
}
