namespace Assets.Scripts
{
    using UnityEngine;
    using Assets.Scripts.AbstractBehaviors;

    public class ForwardFacingAimProviderScript : AimProviderScript
    {
        public override Vector3 GetAimDirection()
        {
            return this.transform.forward;
        }
    }
}