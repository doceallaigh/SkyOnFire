using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
    public ForceProviderScript forceProvider;
    public ProjectileSpawnerScript projectileSpawner;
    public CollisionRelayScript collisionRelayScript;

    public Vector3 translationalVelocity;
    public Vector3 rotationalVelocity;

    // Use this for initialization
    void Start ()
	{
	    this.collisionRelayScript.CollisionEvent += this.HandleCollisionRelay;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    float deltaTime = Time.deltaTime;

	    this.ApplyTranslation(deltaTime);
	    this.ApplyRotation(deltaTime);
	    this.ApplyTranslationalForce(deltaTime);
	    this.ApplyRotationalForce(deltaTime);

	    this.SpawnProjectiles();
    }

    private void ApplyTranslation(float deltaTime)
    {
        this.transform.Translate(this.translationalVelocity * deltaTime, Space.World);
    }

    private void ApplyRotation(float deltaTime)
    {
        this.transform.Rotate(this.rotationalVelocity * deltaTime);
    }

    private void ApplyTranslationalForce(float deltaTime)
    {
        //TODO
        const int mass = 1;

        Vector3 translationalForce = this.forceProvider.GetTranslationalForce();
        Vector3 translationalAcceleration = translationalForce / mass;

        Vector3 translationalMoment = translationalAcceleration * deltaTime;
        this.translationalVelocity += translationalMoment;
    }

    private void ApplyRotationalForce(float deltaTime)
    {
        //TODO
        const int mass = 1;

        Vector3 rotationalForce = this.forceProvider.GetRotationalForce();
        Vector3 rotationalAcceleration = rotationalForce / mass;

        Vector3 rotationalMoment = rotationalAcceleration * deltaTime;
        this.rotationalVelocity += rotationalMoment;
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