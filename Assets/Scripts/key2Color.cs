using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class key2Color : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /////////////////old input system//////////////
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    GetComponent<Renderer>().material.color = Color.red;
        //}
        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    GetComponent<Renderer>().material.color = Color.green;
        //}
        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    GetComponent<Renderer>().material.color = Color.blue;
        //}

////////////////new input system////////////////////////////
        Vector2 mousePosition = Mouse.current.position.ReadValue(); //this is a variable called mousePosition of vector2 (2 values)
                                                                    /// transform.Translate(mousePosition.x, 1 + mousePosition.y, 0);
       Debug.Log("mouse position is " + mousePosition);
        float mouseScreeenPercentageX =  mousePosition.x/Screen.width;
        float mouseScreeenPercentageY = mousePosition.y / Screen.height;
        transform.localScale = new Vector3(2*mouseScreeenPercentageX, 2*mouseScreeenPercentageY, 1);
        /// 
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("A key was pressed");
        }
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            Debug.Log("r key was pressed");
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Keyboard.current.gKey.wasPressedThisFrame)
        {
            Debug.Log("g key was pressed");
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Keyboard.current.bKey.wasPressedThisFrame)
        {
            Debug.Log("b key was pressed");
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
