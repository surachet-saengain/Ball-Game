using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CountDown : MonoBehaviour
{
    public float timeLeft = 30f;
    Text showTime;
    Canvas gameOver;

    // Start is called before the first frame update
    void Start()
    {
        showTime = GameObject.Find("/Canvas/Text/showTime").GetComponent<Text>();
   
        
    }
  
    // Update is called once per frame
    void FixedUpdate()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            showTime.text = timeLeft.ToString("00");
        }
        else
        {
            SceneManager.LoadScene("GameOver");

        }

    }
}
