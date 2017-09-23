namespace Assets.Scripts
{
    using UnityEngine;
    using Assets.Scripts.AbstractBehaviors;

    public class InputForceProviderScript : ForceProviderScript
    {
        // TODO These should be set some other way
        [SerializeField] private float translationAxisMultiplier;

        [SerializeField] private float rotationAxisMultiplier;

        [SerializeField] private Vector3 translationalForce;
        [SerializeField] private Vector3 rotationalForce;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float deltaTime = Time.deltaTime;

            this.UpdateTranslationalForce(deltaTime);
            this.UpdateRotationalForce(deltaTime);
        }

        public override Vector3 GetTranslationalForce()
        {
            return this.translationalForce;
        }

        public override Vector3 GetRotationalForce()
        {
            return this.rotationalForce;
        }

        private void UpdateTranslationalForce(float deltaTime)
        {
            Vector3 strafeTranslation = this.transform.right * Input.GetAxis("Strafe") *
                                        this.translationAxisMultiplier *
                                        deltaTime;
            Vector3 thrustTranslation = this.transform.forward * Input.GetAxis("Thrust") *
                                        this.translationAxisMultiplier *
                                        deltaTime;

            this.translationalForce = strafeTranslation + thrustTranslation;
        }

        private void UpdateRotationalForce(float deltaTime)
        {
            Vector3 yawRotation = this.transform.up * Input.GetAxis("Yaw") * this.rotationAxisMultiplier * deltaTime;

            this.rotationalForce = yawRotation;
        }
    }
}