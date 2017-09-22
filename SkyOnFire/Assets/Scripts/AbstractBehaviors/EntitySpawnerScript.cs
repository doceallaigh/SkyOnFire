using UnityEngine;

public abstract class EntitySpawnerScript : MonoBehaviour
{
    public ActionRestrictorScript actionRestrictorScript;

    public virtual bool TrySpawn()
    {
        if (this.actionRestrictorScript.RestrictionSatisfied())
        {
            this.Spawn();
            this.actionRestrictorScript.ActionTaken();

            return true;
        }

        return false;
    }

    protected abstract void Spawn();
}