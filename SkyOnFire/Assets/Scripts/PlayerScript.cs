using System;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public ForceProviderScript forceProvider;
    public ProjectileSpawnerScript projectileSpawner;

    public Vector3 translationalVelocity;
    public Vector3 rotationalVelocity;

    // Use this for initialization
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
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
        if (Input.GetAxis("Shoot") > 0)
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 shotDirection = mouseRay.direction;

            this.projectileSpawner.Aim(shotDirection);
            this.projectileSpawner.TrySpawn();
        }
    }
}