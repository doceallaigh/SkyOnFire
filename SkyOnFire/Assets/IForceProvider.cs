using UnityEngine;

public interface IForceProvider
{
    Vector3 GetTranslationalForce();

    Vector3 GetRotationalForce();
}
