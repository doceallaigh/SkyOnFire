using UnityEngine;

public class ForwardFacingAimProviderScript : AimProviderScript
{
    public override Vector3 GetAimDirection()
    {
        return this.transform.forward;
    }
}