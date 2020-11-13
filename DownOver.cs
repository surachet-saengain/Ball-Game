using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DownOver : MonoBehaviour
{
    // Start is called before the first frame update
    void GotoGameover()
    {
        SceneManager.LoadScene("GameOver");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
