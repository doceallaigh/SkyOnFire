namespace Assets.Standalone
{
    using UnityEngine;

    internal interface IEngine
    {
        Vector3 UnitForceVector { get; }

        Vector3 ForcePosition { get; }

        float MaxMagnitude { get; }

        void SetActivationRate(float activationRate);
    }
}
