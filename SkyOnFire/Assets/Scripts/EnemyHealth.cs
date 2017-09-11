using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public const int maxHealth = 100;
    public int currentHealth;
    public bool isDead;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
        isDead = false;
	}
	
	// Update is called once per frame
	void Update () {
		//animate stuff
	}

    public void TakeDamage(int amount)
    {
        if(isDead == true)
        {
            return;
        }

        currentHealth -= amount;
        
        if(currentHealth <= 0)
        {
            Die();
        }

    }

    public void Die()
    {
        isDead = true;
    }
}
