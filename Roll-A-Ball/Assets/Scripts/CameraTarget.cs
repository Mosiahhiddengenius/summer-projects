using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform: MonoBehaviour {
    // CameraTarget
    public Transform cam; 
    public Vector3 posOffset;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = cam.position + posOffset;
    }
}
