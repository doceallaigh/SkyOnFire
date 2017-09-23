namespace Assets.Scripts
{
    using System;
    using UnityEngine;
    using Assets.Scripts.AbstractBehaviors;

    public class TimeActionRestrictorScript : ActionRestrictorScript
    {
        [SerializeField] private double timeLimitBetweenActionsSec;

        private DateTime timeLastActionTaken;

        // Use this for initialization
        void Start()
        {
            this.timeLastActionTaken = DateTime.MinValue;
        }

        public override bool RestrictionSatisfied()
        {
            return (DateTime.Now - this.timeLastActionTaken).TotalSeconds > this.timeLimitBetweenActionsSec;
        }

        public override void ActionTaken()
        {
            this.timeLastActionTaken = DateTime.Now;
        }
    }
}