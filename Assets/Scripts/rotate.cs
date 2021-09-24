using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotationSpeed = 90.0f;
    // Start is called before the first frame update
    void Start()
    {
        //initialize a random value each time it starts
        rotationSpeed = Random.value * rotationSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Vector3.right * Time.deltaTime);

        // ...also rotate around the World's Y axis
        transform.Rotate(Vector3.up * Time.deltaTime, Space.World);

        transform.Rotate(transform.up, rotationSpeed * Time.deltaTime);
    }
}
