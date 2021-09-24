using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showObject : MonoBehaviour
{
    // Start is called before the first frame update
    public void Show(string ObjectTag)
    {
        GameObject.FindWithTag(ObjectTag).GetComponent<Text>().enabled = true;
    }
}
