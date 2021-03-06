﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float attackRange;
    [SerializeField] private float attackCoolDown;
    [SerializeField] private Animator animator;

    public float time;
    float distanceToTarget;

    void Start()
    {
       
        //so it doesn't hit itself
        Physics2D.queriesStartInColliders = false;

    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = gameObject.GetComponent<EnemyMovement>().getTargetDistance();
        if (distanceToTarget < attackRange)
        {
            time = time + 1 * Time.deltaTime;
            if (time > attackCoolDown)
            {
                StartCoroutine(Strike());
                time = 0;
            }
        }
        else
        {
            time = 0;
        }

    }

    private IEnumerator Strike()
    {
        // Play attack animation.
        animator.SetBool("attack", true);

        // Continue after the attack animation has completed.
        float myTime = animator.GetCurrentAnimatorStateInfo(2).length;
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(2).length);


        RaycastHit2D hit = Physics2D.Raycast(transform.position, GetComponent<EnemyMovement>().attackDirection, attackRange);
        //Debug.DrawRay(transform.position, GetComponent<EnemyMovement>().attackDirection, Color.green);
        if (hit.collider != null)
        {
            var attackable = hit.collider.GetComponent<Attackable>();
            int damage = gameObject.GetComponent<CharacterStats>().getBaseHit();
            //Vector2 attackingDirection = gameObject.GetComponent<EnemyMovement>().attackDirection;
            if (attackable)
            {
                attackable.OnAttack(damage);
            }
        }
    }

   
}
