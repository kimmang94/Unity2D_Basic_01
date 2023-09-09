using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Button startBtn = null;
    [SerializeField] private Button quitBtn = null;
    [SerializeField] private Button DeliveryGameBtn = null;
    [SerializeField] private Button SnowBoardGameBtn = null;
    
    
    private void Awake()
    {
        startBtn.onClick.AddListener(OnClickStartBtn);
        quitBtn.onClick.AddListener(OnClickQuitBtn);
        DeliveryGameBtn.onClick.AddListener(OnClickDeliveryGameBtn);
        SnowBoardGameBtn.onClick.AddListener(OnClickSnowBoardGameBtn);
    }

    private void OnClickStartBtn()
    {
        SceneManager.LoadScene("GameSelectScene");
    }

    private void OnClickQuitBtn()
    {
        Application.Quit();
    }

    private void OnClickDeliveryGameBtn()
    {
        SceneManager.LoadScene("Delivery Driver Game");
    }
    private void OnClickSnowBoardGameBtn()
    {
        SceneManager.LoadScene("Snow Boarder Game");
    }
}
