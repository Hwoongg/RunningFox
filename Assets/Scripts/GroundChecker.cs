using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool isGround;
    Transform parentTransform;

    private void Start()
    {
        parentTransform = transform.parent;
    }
    private void Update()
    {
        RaycastHit2D hit;

        hit = Physics2D.Linecast(transform.position, parentTransform.position);

        if (hit)
        {
            if (hit.transform.tag == "Ground")
            {
                isGround = true;
            }
            else
            {
                isGround = false;
            }
        }
        else
        {
            isGround = false;
        }
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.tag == "Ground")
    //    {
    //        isGround = true;
    //    }
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.tag == "Ground")
    //    {
    //        isGround = false;
    //    }
    //}

}
