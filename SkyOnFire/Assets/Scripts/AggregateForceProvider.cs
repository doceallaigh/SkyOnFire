using UnityEngine;

public class AggregateForceProvider : ForceProviderScript
{
    [SerializeField] private ForceProviderScript[] aggregatedScripts;

    public override Vector3 GetRotationalForce()
    {
        Vector3 aggregateForce = Vector3.zero;

        foreach (ForceProviderScript forceProvider in this.aggregatedScripts)
        {
            aggregateForce += forceProvider.GetRotationalForce();
        }

        return aggregateForce;
    }

    public override Vector3 GetTranslationalForce()
    {
        Vector3 aggregateForce = Vector3.zero;

        foreach (ForceProviderScript forceProvider in this.aggregatedScripts)
        {
            aggregateForce += forceProvider.GetTranslationalForce();
        }

        return aggregateForce;
    }
}