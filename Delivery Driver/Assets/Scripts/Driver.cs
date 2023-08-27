using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
        transform.Rotate(0f, 0f, 0.1f);
        transform.Translate(0f, 0.01f, 0f);
    }
    
    
}
