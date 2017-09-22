using UnityEngine;

public class HealthTrackerScript : MonoBehaviour
{
    [SerializeField] private const int maxHealth = 5;

    [SerializeField] private int currentHealth;
    [SerializeField] private bool isDead;

    // Use this for initialization
    void Start()
    {
        this.currentHealth = maxHealth;
        this.isDead = false;
        Debug.Log(this.currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //pretty cool animation
        if (this.isDead == true)
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

        Debug.Log("Current Health: " + this.currentHealth);
    }

    public void Die()
    {
        this.isDead = true;
        Destroy(this.gameObject, 3);
    }
}