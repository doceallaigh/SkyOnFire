using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputActionRestrictorScript : ActionRestrictorScript
{
    public string inputAxis;

    public override bool RestrictionSatisfied()
    {
        return Input.GetAxis(this.inputAxis) > 0;
    }

    public override void ActionTaken()
    {
        // Do nothing
    }
}
