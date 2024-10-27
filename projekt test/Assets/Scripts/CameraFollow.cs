using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset;

    //transform.position = Vector3.zero;
    //playerTransform.position = Vector3.zero;
    
    void Update()
    {
        transform.position = playerTransform.position + cameraOffset;
    }
}
