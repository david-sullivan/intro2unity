using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleLight : MonoBehaviour
{
    private Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    myLight.enabled = !myLight.enabled;
        //}
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("space key was pressed");
            myLight.enabled = !myLight.enabled;
        }
    }
}
