using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDector : MonoBehaviour
{
    private float loadDelay = 1f;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Invoke("ReloadScene", loadDelay );
        }
    }
    
    
    private void ReloadScene()
    {
        SceneManager.LoadScene("Snow Boarder Game");
    }
}
