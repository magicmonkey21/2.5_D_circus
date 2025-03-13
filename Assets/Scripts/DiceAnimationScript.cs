using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceAnimationScript : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void RollDice() {
        animator.SetBool("IsRolling", true);
    }

    public void StopDiceRoll() {
        animator.SetBool("IsRolling", false);
    }
    
}
