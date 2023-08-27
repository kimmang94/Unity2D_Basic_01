using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    private void Start()
    {
        transform.Rotate(0, 0, 45f);
    }

    private void Update()
    {
        transform.Rotate(0, 0, 0.1f);
    }
    
    
}
