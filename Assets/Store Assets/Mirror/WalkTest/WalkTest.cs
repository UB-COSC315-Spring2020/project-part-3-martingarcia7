using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkTest : MonoBehaviour
{
    public Animator animator;
    bool walk;
    bool rightfootfirst;

    void Update()
    {
        walk = Input.GetKey(KeyCode.W);
        animator.SetBool("startwalking", walk);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!rightfootfirst)
            {
                rightfootfirst = true;
            }
            else
            {
                rightfootfirst = false;
            }

            animator.SetBool("rightfootwalk", rightfootfirst);
        }
    }
}
