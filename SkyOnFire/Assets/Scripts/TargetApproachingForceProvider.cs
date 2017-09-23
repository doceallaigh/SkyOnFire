namespace Assets.Scripts
{
    using UnityEngine;
    using Assets.Scripts.AbstractBehaviors;

    public class TargetApproachingForceProvider : ForceProviderScript
    {
        [SerializeField] private Transform target;
        [SerializeField] private Vector3 forceLimit;
        [SerializeField] private float translationAxisMultiplier;
        [SerializeField] private Vector3 translationalForce;
        [SerializeField] private float distanceToMaintainFromTarget;

        // Update is called once per frame
        void Update()
        {
            float deltaTime = Time.deltaTime;

            this.UpdateTranslationalForce(deltaTime);
        }

        public override Vector3 GetTranslationalForce()
        {
            return this.translationalForce;
        }

        public override Vector3 GetRotationalForce()
        {
            return Vector3.zero;
        }

        private void UpdateTranslationalForce(float deltaTime)
        {
            Vector3 distanceVector = this.target.position - this.transform.position;
            float distanceToTarget = distanceVector.magnitude;

            float distanceToGoalPosition = distanceToTarget - this.distanceToMaintainFromTarget;
            this.translationalForce = distanceVector.normalized * distanceToGoalPosition;

            this.translationalForce = Vector3.Min(this.translationalForce, this.forceLimit);
            this.translationalForce = Vector3.Max(this.translationalForce, -this.forceLimit);
            this.translationalForce *= deltaTime;
        }
    }
}