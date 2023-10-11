using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3 (14.53f, 0.5319999f, 3.92f);
    private float startDelay = 2;
    private float repeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnObstacles()
    {
      Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

    }
}