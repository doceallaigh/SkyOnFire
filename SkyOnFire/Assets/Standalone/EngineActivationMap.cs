namespace Assets.Standalone
{
    using System.Collections.Generic;

    internal class EngineActivationMap : Dictionary<IEngine, float>
    {
        internal void Combine(EngineActivationMap engineActivationMap)
        {
            foreach (KeyValuePair<IEngine, float> engineActivation in engineActivationMap)
            {
                IEngine engine = engineActivation.Key;
                float activationRate = engineActivation.Value;

                if (!this.ContainsKey(engine))
                {
                    this[engine] = 0.0f;
                }

                this[engine] += activationRate;
            }
        }
    }
}
