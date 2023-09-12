using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    private float loadDelay = 2f;

    [SerializeField] 
    private ParticleSystem finishEffect = null;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }

    }

    private void ReloadScene()
    {
        SceneManager.LoadScene("Snow Boarder Game");
    }
}
