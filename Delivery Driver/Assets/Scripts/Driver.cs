using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    private float steerSpeed = 0.1f;
    private float moveSpeed = 0.01f;
    
    
    private void Start()
    {
    }

    private void Update()
    {
        transform.Rotate(0f, 0f, steerSpeed);
        transform.Translate(0f, moveSpeed, 0f);
    }
    
    
}
