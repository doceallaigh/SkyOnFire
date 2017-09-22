using UnityEngine;

public class InputActionRestrictorScript : ActionRestrictorScript
{
    [SerializeField]
    private string inputAxis;
    
    public override bool RestrictionSatisfied()
    {
        return Input.GetAxis(this.inputAxis) > 0;
    }

    public override void ActionTaken()
    {
        // Do nothing
    }
}
