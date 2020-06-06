using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10.0f;
    Animator anim;
    Rigidbody2D rig;
    Vector3 moveFactor;

    [SerializeField] float jumpPower = 100;
    [SerializeField] GroundChecker gc;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        //transform.Translate(moveSpeed * inputX * Time.deltaTime, 0, 0);
        moveFactor = rig.velocity;
        moveFactor.x = inputX * moveSpeed;
        rig.velocity = moveFactor;

        if(inputX > 0) // 오른쪽으로 갈 때
        {
            anim.SetBool("isRunning", true);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(inputX < 0)
        {
            anim.SetBool("isRunning", true);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 JumpFactor = new Vector2(0, jumpPower);
            rig.AddForce(JumpFactor);
        }

        anim.SetFloat("yVelocity", rig.velocity.y);
        anim.SetBool("isGround", gc.isGround);
    }
}
