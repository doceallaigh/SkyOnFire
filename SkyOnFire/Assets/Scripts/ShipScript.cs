namespace Assets.Scripts
{
    using UnityEngine;
    using Assets.Scripts.AbstractBehaviors;

    public class ShipScript : MonoBehaviour
    {
        [SerializeField] private ForceProviderScript forceProvider;
        [SerializeField] private ProjectileSpawnerScript projectileSpawner;
        [SerializeField] private CollisionHandlerScript[] collisionHandlerScripts;
        [SerializeField] private Vector3 translationalVelocity;
        [SerializeField] private Vector3 rotationalVelocity;

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

        #region Unity Messages

        /// <summary>
        /// Called once when the instance of this script is loaded, which is guaranteed to be:
        ///    1. After all objects have been initialized with editor parameters
        ///    2. Before Start or Update is called for any script
        /// </summary>
        /// <remarks>
        /// Awake should be used to initialize parameters not set in the editor and link references between scripts.
        /// </remarks>
        private void Awake()
        {
            // Do nothing
        }

        /// <summary>
        /// Called once immediately prior to Update on the first time this script is enabled which is guaranteed to be:
        ///    1. After Awake has been called on all scripts
        /// </summary>
        /// <remarks>
        /// Start should be used to:
        ///    1. Pass information between scripts 
        ///    2. Initialize parameters which do not need to be set until the script is enabled
        /// </remarks>
        private void Start()
        {
            // Do nothing
        }

        /// <summary>
        /// Called every frame, but only if the script is enabled.
        /// </summary>
        /// <remarks>
        /// Unlike FixedUpdate, there is no guarantee on the length of the interval between calls to Update
        /// In order to get the elapsed time since last call to Update, use Time.deltaTime.
        /// </remarks>
        private void Update()
        {
            float deltaTime = Time.deltaTime;

            // These steps should be done via RigidBody
            this.ApplyTranslation(deltaTime);
            this.ApplyRotation(deltaTime);
            this.ApplyTranslationalForce(deltaTime);
            this.ApplyRotationalForce(deltaTime);

            this.SpawnProjectiles();
        }

        /// <summary>
        /// Called every fixed framerate frame, but only if the script is enabled.
        /// </summary>
        /// <remarks>
        /// Update is guaranteed to be called at constant intervals
        /// In order to get the elapsed time since last call to Update, use Time.deltaTime.
        /// </remarks>
        private void FixedUpdate()
        {
            // Do nothing
        }

        /// <summary>
        /// Equivalent to Update, but called after Update has been called for all scripts this frame.
        /// </summary>
        private void LateUpdate()
        {
            // Do nothing
        }

        #endregion

        #region Unity Events

        /// <summary>
        /// Called in response to GUI events, but only if the script is enabled.
        /// </summary>
        /// <remarks>
        /// OnGUI may be called more than once per frame, depending on the number of GUI events.
        /// </remarks>
        private void OnGUI()
        {
            // Do nothing
        }

        /// <summary>
        /// Called when the script is disabled or destroyed.
        /// </summary>
        private void OnDisable()
        {
            // Do nothing
        }

        /// <summary>
        /// Called when the script is enabled.
        /// </summary>
        private void OnEnable()
        {
            // Do nothing
        }

        #endregion
    }
}