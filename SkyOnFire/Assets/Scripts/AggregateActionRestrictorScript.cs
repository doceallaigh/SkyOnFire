using UnityEngine;

public class AggregateActionRestrictorScript : ActionRestrictorScript
{
    [SerializeField]
    private ActionRestrictorScript[] aggregatedScripts;

    public override bool RestrictionSatisfied()
    {
        foreach (ActionRestrictorScript restrictor in this.aggregatedScripts)
        {
            if (!restrictor.RestrictionSatisfied())
            {
                return false;
            }
        }

        return true;
    }

    public override void ActionTaken()
    {
        foreach (ActionRestrictorScript restrictor in this.aggregatedScripts)
        {
            restrictor.ActionTaken();
        }
    }
}
