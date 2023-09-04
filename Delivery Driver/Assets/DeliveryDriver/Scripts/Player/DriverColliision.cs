using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverColliision : MonoBehaviour
{

    private Driver driver = null;
    [SerializeField] private float slowSpeed = 5f;
    private void Start()
    {
        driver = GetComponent<Driver>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        driver.moveSpeed = slowSpeed;
    }
}
