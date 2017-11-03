using System.Runtime.CompilerServices;

namespace Assets.Scripts
{
    using System;
    using Assets.Scripts.AbstractBehaviors;
    using Assets.Standalone;
    using UnityEngine;

    public class Engine : ForceProviderScript, IEngine
    {
        [SerializeField] private Vector3 unitForceVector;
        [SerializeField] private Vector3 forcePositionOffset;
        [SerializeField] private float maxMagnitude;
        [SerializeField] private float magnitude;

        public Vector3 UnitForceVector
        {
            get { return this.unitForceVector; }
        }

        public Vector3 ForcePosition
        {
            get { return this.transform.position + this.forcePositionOffset; }
        }

        public float MaxMagnitude
        {
            get { return this.maxMagnitude; }
        }

        public void SetActivationRate(float activationRate)
        {
            activationRate = Math.Max(activationRate, 0.0f);
            activationRate = Math.Min(activationRate, 1.0f);

            this.magnitude = this.maxMagnitude * activationRate;
        }

        public override Vector3 GetTranslationalForce()
        {
            return this.unitForceVector * this.magnitude;
        }

        public override Vector3 GetRotationalForce()
        {
            return Vector3.zero;
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
            // Do nothing
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