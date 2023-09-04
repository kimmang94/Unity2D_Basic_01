using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigid2d = null;

    [SerializeField] private float torqueAmount = 1f;
    
    private void Start()
    { 
         rigid2d = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigid2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigid2d.AddTorque(-torqueAmount);
        }
    }
}
