using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDector : MonoBehaviour
{
    private float loadDelay = 1f;
    [SerializeField] private ParticleSystem playerPaticle = null;
    [SerializeField] private AudioClip crashSFX = null;

    private bool hasCrashed = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            playerPaticle.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay );
            FindObjectOfType<PlayerController>().DisableControlls();;
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
