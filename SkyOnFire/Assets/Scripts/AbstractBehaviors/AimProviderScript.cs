namespace Assets.Scripts.AbstractBehaviors
{
    using UnityEngine;

    public abstract class AimProviderScript : MonoBehaviour
    {
        public abstract Vector3 GetAimDirection();
    }
}