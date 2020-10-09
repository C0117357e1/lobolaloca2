using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    void Update()  //ゲーム終了
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            doquit();
        }
    }
    public void doquit()
    {
        Application.Quit();
    }
}
