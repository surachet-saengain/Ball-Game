using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(dir*Time.deltaTime * 10,Space.World);


        Vector3 rot = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
        //if (Input.GetKey("up"))
        {
            transform.Rotate(rot*400*Time.deltaTime,Space.World);
        }

        //if (Input.GetKey("right"))
        {
        //    transform.Rotate(0, 0, 1);
        }
    }
}
