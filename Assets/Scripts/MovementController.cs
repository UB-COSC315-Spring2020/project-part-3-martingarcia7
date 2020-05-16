using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    float playerMovementSpeed = 8;
    float movementSpeed = 4;
    float rotationSpeed = 120;
    float rot = 0;
    float gravity = 8;

    Vector3 moveDirection = Vector3.zero;

    CharacterController controller;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        if (controller.isGrounded)
        {
            //Reset the moveDirection once, at the beginning of the frame.
            moveDirection = new Vector3(0, 0, 0);

            //If W is pressed, apply force forward
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("running", true);
                moveDirection = (Vector3.forward * playerMovementSpeed);
                moveDirection = transform.TransformDirection(moveDirection);
            }
            //Otherwise set running to false
            else
            {
                anim.SetBool("running", false);
            }

            if (Input.GetKeyDown(KeyCode.T))
            {
                anim.SetBool("punching", true);
            }

            else
            {
                anim.SetBool("punching", false);
            }

            //If Space is pressed, the bool of the jump animation is set to true
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetBool("jumping", true);
                //If running is also true, then add the jumping force to the moveDirection, which will include the previous running force, letting them be combined
                if (anim.GetBool("running"))
                {
                    moveDirection += (Vector3.up * movementSpeed);
                }
            
            }
            //Otherwise jumping is set to false
            else
            {
                anim.SetBool("jumping", false);
            }
                       
            //Based on which other bools are active, determines if should set idle to true or false. True if no others are active.
            if (anim.GetBool("jumping") || anim.GetBool("running"))
            {
                anim.SetBool("idle", false);
            }
            else
            {
                anim.SetBool("idle", true);
            }

            if (anim.GetBool("jumping") || anim.GetBool("running"))
            {
                anim.SetBool("punching", false);
            }

          
        }
        rot += Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

}
