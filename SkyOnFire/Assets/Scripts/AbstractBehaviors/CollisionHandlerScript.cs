namespace Assets.Scripts.AbstractBehaviors
{
    using UnityEngine;

    public abstract class CollisionHandlerScript : MonoBehaviour
    {
        protected abstract void HandleTriggerCollision(Collider collider);

        private void OnTriggerEnter(Collider collider)
        {
            this.HandleTriggerCollision(collider);
        }
    }
}