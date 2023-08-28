using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("트리거!!");
    }
}
