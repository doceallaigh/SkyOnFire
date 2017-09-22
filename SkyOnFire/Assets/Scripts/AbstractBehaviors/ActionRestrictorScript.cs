using UnityEngine;

public abstract class ActionRestrictorScript : MonoBehaviour
{
    public abstract bool RestrictionSatisfied();

    public abstract void ActionTaken();
}
