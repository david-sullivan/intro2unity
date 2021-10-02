using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //use the new input system

public class Fall_SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    public GameObject[] fallingObjectsPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            
        }
    }

    void SpawnRandomObject()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int objectIndex = Random.Range(0, fallingObjectsPrefabs.Length);
        Instantiate(fallingObjectsPrefabs[objectIndex], spawnPos, fallingObjectsPrefabs[objectIndex].transform.rotation);
    }
}
