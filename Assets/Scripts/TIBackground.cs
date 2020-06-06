using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIBackground : TIObject
{
    CameraController camController;

    public override void Start()
    {
        base.Start();

        camController = FindObjectOfType<CameraController>();
    }
    // 카메라 추적 기능
    private void Update()
    {
        Vector3 newPos = transform.position;

        newPos.x = camController.transform.position.x;

        transform.position = newPos;
        
    }
}
