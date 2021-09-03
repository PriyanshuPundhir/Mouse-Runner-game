using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aniamtioncontroler : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool Walking = animator.GetBool("Walking");
        bool forwordPressed = Input.GetKey("up");
        bool Walk = animator.GetBool("Walk");
        bool downPressed = Input.GetKey("down");
        bool Left = animator.GetBool("Left");
        bool leftPressed = Input.GetKey("left");
        bool Right = animator.GetBool("Right");
        bool rightPressed = Input.GetKey("right");
        bool Jump = animator.GetBool("Jump");
        bool JumpPressed = Input.GetKey("space");
        bool Dance = animator.GetBool("Dance");
        bool DancePressed = Input.GetKey("r");
        bool Twerk = animator.GetBool("Twerk");
        bool TwerkPressed = Input.GetKey("t");
        if (forwordPressed)
        {
            animator.SetBool("Walking", true);
        }
        if (!forwordPressed)
        {
            animator.SetBool("Walking", false);
        }
        if (downPressed)
        {
            animator.SetBool("Walk", true);
        }
        if (!downPressed)
        {
            animator.SetBool("Walk", false);
        }
        if (leftPressed)
        {
            animator.SetBool("Left", true);
        }
        if (!leftPressed)
        {
            animator.SetBool("Left", false);
        }
        if (rightPressed)
        {
            animator.SetBool("Right", true);
        }
        if (!rightPressed)
        {
            animator.SetBool("Right", false);
        }

        if (JumpPressed && forwordPressed)
        {
            animator.SetBool("Jump", true);
        }
        if (!JumpPressed && forwordPressed)
        {
            animator.SetBool("Jump", false);
        }
        if (JumpPressed )
        {
            animator.SetBool("Jump", true);
        }
        if (!JumpPressed )
        {
            animator.SetBool("Jump", false);
        }
        if (DancePressed)
        {
            animator.SetBool("Dance", true);
        }
        if (!DancePressed)
        {
            animator.SetBool("Dance", false);
        }
        if (TwerkPressed)
        {
            animator.SetBool("Twerk", true);
        }
        if (!TwerkPressed)
        {
            animator.SetBool("Twerk", false);
        }
    }
}
