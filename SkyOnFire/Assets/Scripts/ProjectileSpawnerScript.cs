using UnityEngine;

public class ProjectileSpawnerScript : EntitySpawnerScript
{
    public int projectileSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    protected override void Spawn()
    {
        GameObject projectileGameObject = GameObject.Instantiate(Resources.Load("Projectile")) as GameObject;
        ProjectileScript projectileScript = projectileGameObject.GetComponent<ProjectileScript>();
        projectileScript.transform.position = this.transform.position;
        projectileScript.velocity = this.transform.forward.normalized * this.projectileSpeed;
    }
}
