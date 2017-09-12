using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRelayScript : MonoBehaviour
{
    public class CollisionEventArgs : EventArgs
    {
        public CollisionEventArgs(Collider collider)
        {
            this.Collider = collider;
        }

        public Collider Collider { get; private set; }
    }

    public EventHandler<CollisionEventArgs> CollisionEvent { get; set; }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CollisionEvent != null)
        {
            CollisionEventArgs collisionEventArgs = new CollisionEventArgs(other);
            this.CollisionEvent.Invoke(this, collisionEventArgs);
        }
    }
}