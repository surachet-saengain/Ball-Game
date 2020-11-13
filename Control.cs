using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
     float speed = 15f;
  //float rotationSpeed = 1000f;
  //private float jume = 50f;


    Rigidbody Rb;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void FixedUpdate()

    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Rb.AddForce(movement * speed);

        
      //  if (Input.GetKey(KeyCode.LeftArrow))
        {
        //    Rb.MovePosition(Rb.position + new Vector3(-speed, 0) * Time.deltaTime);

        }
        //if (Input.GetKey(KeyCode.RightArrow))
        {
        //    Rb.MovePosition(Rb.position + new Vector3(speed, 0) * Time.deltaTime);

        }
     // if (Input.GetKeyDown(KeyCode.Space))
        {
     //     Rb.MovePosition(Rb.position + new Vector3(0, jume) * Time.deltaTime);

        }

        

    }
    }
