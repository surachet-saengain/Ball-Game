using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playEf : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
   
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    { 
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            rend.enabled = false;
        Destroy(this.gameObject,audio.clip.length);
    }
}
