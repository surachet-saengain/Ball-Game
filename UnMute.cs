using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnMute : MonoBehaviour
{
    public AudioSource Sound;
    public void PlaySound()
    {

        Sound.Play();

    }
    public void StopSound()
    {

        Sound.Stop();

    }
}

