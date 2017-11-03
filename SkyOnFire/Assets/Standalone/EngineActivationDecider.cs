namespace Assets.Standalone
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    internal class EngineActivationDecider
    {
        private IEnumerable<IEngine> engines;

        internal EngineActivationDecider(IEnumerable<IEngine> engines)
        {
            this.engines = new List<IEngine>(engines);
        }

        internal EngineActivationMap GetTargetEngineActivationMap(Vector3 targetForceVector)
        {
            Vector3 unitTargetVector = targetForceVector.normalized;
            EngineActivationMap engineActivationMap = new EngineActivationMap();

            IList<IEngine> directMatchEngines = new List<IEngine>();
            IList<IEngine> eligibleEngines = new List<IEngine>();

            foreach (IEngine engine in this.engines)
            {
                Vector3 engineUnitVector = engine.UnitForceVector;

                if (engineUnitVector == unitTargetVector)
                {
                    directMatchEngines.Add(engine);
                }
                else if (Mathf.Abs(Vector3.Angle(engineUnitVector, unitTargetVector)) <= 90.0f)
                {
                    eligibleEngines.Add(engine);
                }
            }

            foreach (IEngine engine in directMatchEngines)
            {
                float magnitudeUsed = Math.Min(engine.MaxMagnitude, targetForceVector.magnitude);
                float activationRate = magnitudeUsed / engine.MaxMagnitude;

                targetForceVector -= engine.UnitForceVector * activationRate;

                engineActivationMap[engine] = activationRate;
            }

            if (Mathf.Approximately(targetForceVector.magnitude, 0.0f))
            {
                return engineActivationMap;
            }

            engineActivationMap.Combine(this.GetBalancedContributionMap(eligibleEngines, targetForceVector));

            return engineActivationMap;
        }

        private EngineActivationMap GetBalancedContributionMap(IList<IEngine> contributorEngines, Vector3 targetForceVector)
        {
            //// For each engine, split force vector into components parrallel and perpendicular to target force vector
            //// Chain parallel components together, recording crossings/loops
            //// Engine activation is dictated by the loop corresponding to the greatest parallel component sum

            EngineActivationMap activationMap = new EngineActivationMap();
            return activationMap;
        }
    }
}