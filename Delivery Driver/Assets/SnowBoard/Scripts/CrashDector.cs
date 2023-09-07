using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("Hit my Head");
        }
    }
}
