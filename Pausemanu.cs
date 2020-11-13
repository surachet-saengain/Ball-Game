using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pausemanu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    public void OpenPaues()
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
