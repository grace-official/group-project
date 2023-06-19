using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats : MonoBehaviour
{
    public float damage;
    public float swingTime;
    public float range;

    public WeaponController weaponController;

    private BoxCollider hitBox;

    private void Start()
    {
        hitBox = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(weaponController.canAttack)
        {
            hitBox.enabled = false;
        }
        else
        {
            hitBox.enabled = true;
        }
    }
}
