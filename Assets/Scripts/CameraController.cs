using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    PlayerController pc;
    Vector3 newPos;

    // Start is called before the first frame update
    void Start()
    {
        pc = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        newPos = pc.transform.position;

        newPos.z = -10;
        transform.position = newPos;
    }
}
