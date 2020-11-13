using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doornext : MonoBehaviour
{
    private int next;
    // Start is called before the first frame update
    void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            SceneManager.LoadScene(next);
        }
    }
}
