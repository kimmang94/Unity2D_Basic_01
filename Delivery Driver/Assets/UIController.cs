using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Button startBtn = null;
    [SerializeField] private Button quitBtn = null;
    private void Awake()
    {
        startBtn.onClick.AddListener(OnClickStartBtn);
        quitBtn.onClick.AddListener(OnClickQuitBtn);
    }

    private void OnClickStartBtn()
    {
        SceneManager.LoadScene("GameSelectScene");
    }

    private void OnClickQuitBtn()
    {
        Application.Quit();
    }
}
