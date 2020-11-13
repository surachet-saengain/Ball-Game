using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;
    float distance = -4f;
    float lift = 0.5f;
    void Update()
    {
        transform.position = target.position + (new Vector3(0, lift, distance));
        transform.LookAt(target);
    }
}
