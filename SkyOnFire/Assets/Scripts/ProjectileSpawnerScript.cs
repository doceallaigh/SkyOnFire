using System;
using UnityEngine;

public class ProjectileSpawnerScript : EntitySpawnerScript
{
    public int projectileSpeed;

    private Vector3 aimDirection;

    // Use this for initialization
    void Start()
    {
        this.aimDirection = this.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Aim(Vector3 shotDirection)
    {
        this.aimDirection = shotDirection;
    }

    protected override void Spawn()
    {
        GameObject projectileGameObject = GameObject.Instantiate(Resources.Load("Projectile")) as GameObject;
        ProjectileScript projectileScript = projectileGameObject.GetComponent<ProjectileScript>();
        projectileScript.transform.position = this.transform.position;
        projectileScript.velocity = this.aimDirection.normalized * this.projectileSpeed;
    }
}