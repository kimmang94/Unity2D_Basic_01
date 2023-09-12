using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTail : MonoBehaviour
{
    [SerializeField] private ParticleSystem moveParticle = null;
    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            moveParticle.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("탈출");
        moveParticle.Stop();
        
        
    }
}
