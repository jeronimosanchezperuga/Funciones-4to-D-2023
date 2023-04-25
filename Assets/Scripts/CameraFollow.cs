using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform moscaTr;

    void Update()
    {
        if (moscaTr) {
            transform.position = moscaTr.position - Vector3.forward;
        }
    }
}
