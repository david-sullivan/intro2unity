using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //use the new input system

public class Fall_SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    public GameObject[] fallingObjectsPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int objectIndex = Random.Range(0, fallingObjectsPrefabs.Length);
            Instantiate(fallingObjectsPrefabs[objectIndex], spawnPos, fallingObjectsPrefabs[objectIndex].transform.rotation);
        }
    }
}
