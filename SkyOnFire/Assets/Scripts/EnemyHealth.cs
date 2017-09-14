using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public const int maxHealth = 5;
    public int currentHealth;
    public bool isDead;

	// Use this for initialization
	void Start () {
        this.currentHealth = maxHealth;
        this.isDead = false;
	}
	
	// Update is called once per frame
	void Update () {
        //pretty cool animation
        if(this.isDead == true)
        {
            this.transform.Rotate(10, 20, 15);
        }
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
        Destroy(this.gameObject, 3);
    }
}