using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    // Health/Damage
    public int maxHealth = 100;
    public int currentHealth;
    //private DamagingObject dmgO;
    public int damage = 10;

    public float damageStartingTime;
    public float damageCurrentTime;

    public bool canTakeDamage;

    public HealthBar healthBar;
    // Start is called before the first frame update

    private void Update()
    {
        takeSustainedDamage();
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void Start()
    {
        canTakeDamage = true;
        damageCurrentTime = damageStartingTime;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.tag == "SustainedDamagingObject" && canTakeDamage)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
            damageCurrentTime = damageStartingTime;
            canTakeDamage = false;
        }
    }

    private void takeSustainedDamage ()
    {
        if (!canTakeDamage)
        {
            damageCurrentTime -= 1 * Time.deltaTime;
            if (damageCurrentTime < 0)
            {
                canTakeDamage = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DamagingObject")
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }
    }
}
