using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public const int maxHealth = 100;
    public int currentHealth;
    public bool isDead;

    // Use this for initialization
    void Start()
    {
        this.currentHealth = maxHealth;
        this.isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        //animate stuff
    }

    public void TakeDamage(int amount)
    {
        if (this.isDead == true)
        {
            return;
        }

        this.currentHealth -= amount;

        if (this.currentHealth <= 0)
        {
            this.Die();
        }
    }

    public void Die()
    {
        this.isDead = true;
    }
}