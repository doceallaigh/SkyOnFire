using UnityEngine;

public abstract class ForceProviderScript : MonoBehaviour
{
    public abstract Vector3 GetTranslationalForce();

    public abstract Vector3 GetRotationalForce();
}