using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public AnimationCurve DirectionCurve;
    public float Scale = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * DirectionCurve.Evaluate(Mathf.Repeat(Time.time, 1f)) * Time.deltaTime * Scale;
    }
}
