namespace Assets.Scripts
{
    using UnityEngine;
    using Assets.Scripts.AbstractBehaviors;

    public class ProjectileSpawnerScript : EntitySpawnerScript
    {
        [SerializeField] private int projectileSpeed;
        [SerializeField] private AimProviderScript aimProviderScript;
        [SerializeField] private Vector3 aimDirection;

        // Use this for initialization
        void Start()
        {
            this.aimDirection = this.aimProviderScript.GetAimDirection();
        }

        // Update is called once per frame
        void Update()
        {
            this.aimDirection = this.aimProviderScript.GetAimDirection();
        }

        protected override void Spawn()
        {
            GameObject projectileGameObject = GameObject.Instantiate(Resources.Load("Projectile")) as GameObject;
            ProjectileScript projectileScript = projectileGameObject.GetComponent<ProjectileScript>();
            projectileScript.transform.position = this.transform.position;
            projectileScript.velocity = this.aimDirection.normalized * this.projectileSpeed;
        }
    }
}