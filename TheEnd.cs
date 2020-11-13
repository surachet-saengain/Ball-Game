using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void GotoGameover()
    {
        SceneManager.LoadScene("ThsEnd");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("TheEnd");
        }
    }
}
