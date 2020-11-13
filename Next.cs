using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{

   public void GotoManu()
    {
        SceneManager.LoadScene("Manu");
    }
    public void GotoGame1()
    {
        SceneManager.LoadScene("Game1");
    }
    public void GotoGame2()
    {
        SceneManager.LoadScene("Game2");
    }
}
