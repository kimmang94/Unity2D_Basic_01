using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverColliision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("부딪힘!");
    }
}
