namespace Assets.Standalone
{
    using UnityEngine;

    internal struct ForceActuatorModel
    {
        internal Vector3 UnitForceVector { get; set; }

        internal Vector3 SourcePosition { get; set; }

        internal double MinimumMagnitude { get; set; }

        internal double MaximumMagnitude { get; set; }
    }
}