using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausescript : MonoBehaviour
{
    public  bool gameispaused = false;
    public GameObject pauseMenuUI;　　　　// 一時停止・再開やメニュー インタフェース
    public GameObject pauseMenuUI2;
    public GameObject pauseMenuUI3;
    public GameObject pauseMenuUI4;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            hacerlo();
        }
        if (Input.GetButtonDown("pause"))
            {
                if (gameispaused)
            {
                Resume();
            }
            else {
                Pausar();
            }
        }   
    }

    public void hacerlo()
    {
            if (gameispaused)
            {
                Resume();
            }
            else
            {
                Pausar();   
            }
    }

    void Resume() {                     //プレイ状態
        pauseMenuUI3.SetActive(true);
        pauseMenuUI2.SetActive(true);
        pauseMenuUI4.SetActive(false);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;
    }
    void Pausar()                        //一時停止状態
    {
        pauseMenuUI3.SetActive(false);
        pauseMenuUI2.SetActive(false);
        pauseMenuUI4.SetActive(true);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
    }
}
