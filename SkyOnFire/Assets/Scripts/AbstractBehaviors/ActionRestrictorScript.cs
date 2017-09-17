using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionRestrictorScript : MonoBehaviour
{
    public abstract bool RestrictionSatisfied();

    public abstract void ActionTaken();
}
