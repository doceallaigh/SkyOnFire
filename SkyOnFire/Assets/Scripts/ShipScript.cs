using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public ForceProviderScript forceProvider;
    public ProjectileSpawnerScript projectileSpawner;

    public CollisionHandlerScript[] collisionHandlerScripts;

    public Vector3 translationalVelocity;
    public Vector3 rotationalVelocity;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.deltaTime;

        // These steps should be done via RigidBody
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
}