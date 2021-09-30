using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManage : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 3;
    private PlayerController playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        //Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // if the game isn't over, spawn a obstacle (this function is called by invokeRepeating in start)
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

    }
}
