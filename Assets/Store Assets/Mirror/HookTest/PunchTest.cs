using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchTest : MonoBehaviour
{
    public Animator animator;
    bool ThrowPunch;
    bool UseRightHand;

    void Update()
    {
        ThrowPunch = Input.GetKey(KeyCode.Space);
        animator.SetBool("punch", ThrowPunch);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!UseRightHand)
            {
                UseRightHand = true;
            }
            else
            {
                UseRightHand = false;
            }

            animator.SetBool("righthandhook", UseRightHand);
        }
    }
}
