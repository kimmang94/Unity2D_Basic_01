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

    [SerializeField] private AudioSource audioSource = null;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            finishEffect.Play();
            audioSource.Play();
            
            Invoke("ReloadScene", loadDelay);
        }

    }
    /// <summary>
    /// Scene 을 로드하기 위한 기능
    /// </summary>
    private void ReloadScene()
    {
        SceneManager.LoadScene("Snow Boarder Game");
    }
}
