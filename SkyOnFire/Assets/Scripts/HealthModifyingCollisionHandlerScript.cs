using UnityEngine;

public class HealthModifyingCollisionHandlerScript : CollisionHandlerScript
{
    public HealthTrackerScript healthTrackerScript;

    protected override void HandleTriggerCollision(Collider other)
    {
        this.healthTrackerScript.TakeDamage(1);

        Debug.Log("Current Health: " + this.healthTrackerScript.currentHealth);

        // TODO This should be split out into a separate handler
        Debug.Log("yeehaw");

        if (other.name == "PlayerShip")
        {
            Debug.Log("buh");
        }
    }
}