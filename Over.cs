using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Over : MonoBehaviour
{
    void GotoGameover2()
    {
        SceneManager.LoadScene("GameOver2");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("GameOver2");
        }
    }
}
