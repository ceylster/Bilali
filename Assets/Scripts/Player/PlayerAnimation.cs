using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    private int runHash = Animator.StringToHash("Run");
    private int speedHash = Animator.StringToHash("Speed");
    private bool isMoving;
    
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SetMovement(Vector3 finalInput)
    {
        anim.SetBool(runHash, finalInput.sqrMagnitude > 0);
        anim.SetFloat(speedHash, finalInput.z);
    }
}
