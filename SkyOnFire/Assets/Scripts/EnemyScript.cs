using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
    public ProjectileSpawnerScript projectileSpawner;
    public CollisionRelayScript collisionRelayScript;

	// Use this for initialization
	void Start ()
	{
	    this.collisionRelayScript.CollisionEvent += this.HandleCollisionRelay;
	}
	
	// Update is called once per frame
	void Update () {
        this.SpawnProjectiles();
	}

    private void SpawnProjectiles()
    {
        this.projectileSpawner.TrySpawn();
    }

    private void HandleCollisionRelay(object sender, CollisionRelayScript.CollisionEventArgs eventArgs)
    {
        this.OnTriggerEnter(eventArgs.Collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("yeehaw");

        if (other.name == "PlayerShip")
        {
            Debug.Log("buh");
        }
    }
}
