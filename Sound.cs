using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private void Play()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
