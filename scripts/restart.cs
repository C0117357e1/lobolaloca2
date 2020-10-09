using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    void Update()  //ゲーム再起動
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    public void RestartGame()
    {
      SceneManager.LoadScene("testscript");
        Time.timeScale = 1f;
    }
}
