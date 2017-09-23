﻿namespace Assets.Scripts
{
    using UnityEngine;

    public class HealthTrackerScript : MonoBehaviour
    {
        [SerializeField] private const int maxHealth = 5;

        [SerializeField] private int currentHealth;
        [SerializeField] private bool isDead;

        public void TakeDamage(int amount)
        {
            if (this.isDead == true)
            {
                return;
            }

            this.currentHealth -= amount;

            if (this.currentHealth <= 0)
            {
                this.Die();
            }

            Debug.Log("Current Health: " + this.currentHealth);
        }

        public void Die()
        {
            this.isDead = true;
            Destroy(this.gameObject, 3);
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
            this.currentHealth = maxHealth;
            this.isDead = false;
            Debug.Log(this.currentHealth);
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
            //pretty cool animation
            if (this.isDead == true)
            {
                this.transform.Rotate(10, 20, 15);
            }
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