using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSwingAnimation : MonoBehaviour
{
    Animator anim;
    /*[HideInInspector] */public bool isAttacking = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isAttacking", isAttacking);
    }

    public void AttackEnded(string message)
    {
        if (message.Equals("AttackAnimationEnded"))
        {
            isAttacking = false;
        }
    }
}