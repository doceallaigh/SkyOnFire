public class AggregateActionRestrictorScript : ActionRestrictorScript
{
    public ActionRestrictorScript[] aggregatedScripts;

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
