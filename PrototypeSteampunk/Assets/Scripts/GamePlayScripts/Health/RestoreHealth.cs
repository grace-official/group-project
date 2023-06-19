using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestoreHealth : MonoBehaviour
{
    public Health health;
    public HealthBar healthBar;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            health.currentHealth = health.maxHealth;
            healthBar.SetHealth(health.currentHealth);
        }
    }
}
