using UnityEngine;

public class HealthModifyingCollisionHandlerScript : CollisionHandlerScript
{
    [SerializeField] private HealthTrackerScript healthTrackerScript;

    private void Start()
    {
    }

    protected override void HandleTriggerCollision(Collider other)
    {
        this.healthTrackerScript.TakeDamage(1);

        // TODO This should be split out into a separate handler
        Debug.Log("yeehaw");

        if (other.name == "PlayerShip")
        {
            Debug.Log("buh");
        }
    }
}