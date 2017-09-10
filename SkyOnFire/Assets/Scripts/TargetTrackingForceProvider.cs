using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTrackingForceProvider : ForceProviderScript
{
    public Transform target;
    public Vector3 forceLimit;
    public float rotationAxisMultiplier;

    private Vector3 rotationalForce;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.deltaTime;

        this.UpdateRotationalForce(deltaTime);
    }

    public override Vector3 GetTranslationalForce()
    {
        return Vector3.zero;
    }

    public override Vector3 GetRotationalForce()
    {
        return this.rotationalForce;
    }

    private void UpdateRotationalForce(float deltaTime)
    {
        Quaternion targetRotation = Quaternion.LookRotation(this.target.position - this.transform.position, this.transform.up);

        // TODO This should be done in a less naive way
        this.rotationalForce = new Vector3(
            targetRotation.eulerAngles.x - this.transform.rotation.eulerAngles.x, 
            targetRotation.eulerAngles.y - this.transform.rotation.eulerAngles.y, 
            targetRotation.eulerAngles.z - this.transform.rotation.eulerAngles.z);
        this.rotationalForce *= this.rotationAxisMultiplier;

        this.rotationalForce = Vector3.Min(this.rotationalForce, this.forceLimit);
        this.rotationalForce = Vector3.Max(this.rotationalForce, -this.forceLimit);
        this.rotationalForce *= deltaTime;
    }
}