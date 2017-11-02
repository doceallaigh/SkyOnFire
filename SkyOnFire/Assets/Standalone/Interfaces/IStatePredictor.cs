namespace Assets.Standalone.Interfaces
{
    internal interface IStatePredictor
    {
        StateModel PredictState(StateModel stateModel, ActionModel actionModel);
    }
}