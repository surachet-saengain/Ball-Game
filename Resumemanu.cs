using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resumemanu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pauseMenuUI;
    public void ClosePaues()
    {

        if (GameIsPause)
        {
            Resums();
        }
        else
        {
            Pause();
        }

    }
    void Resums()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }


    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
}
