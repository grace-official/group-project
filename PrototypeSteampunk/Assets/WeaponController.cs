using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject weapon;
    public bool canAttack = true;
    public float attackCd = 1.0f;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(canAttack)
            {
                weaponAttack();
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (canAttack)
            {
                heavyAttack();
            }
        }
    }

    public void weaponAttack()
    {
        canAttack = false;
        Animator anim = weapon.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        StartCoroutine(resetAttackCd(attackCd));
    }

    public void heavyAttack()
    {
        canAttack = false;
        Animator anim = weapon.GetComponent<Animator>();
        anim.SetTrigger("HeavyAttack");
        StartCoroutine(resetAttackCd(attackCd * 1.5f));
    }

    IEnumerator resetAttackCd(float cooldown)
    {
        yield return new WaitForSeconds(cooldown);
        canAttack = true;
    }
}
