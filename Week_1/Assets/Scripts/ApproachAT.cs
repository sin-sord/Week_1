using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEditor;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions
{

    public class ApproachAT : ActionTask
    {

        public Transform target;
        private float speed;
        public float arrivalDistance;
        public float chargeUseRate;

        private Blackboard agentBlackboard;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit()
        {


            return null;
        }

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute()
        {

            // used to get variables on blackboard in the objects Inspector
            agentBlackboard = agent.GetComponent<Blackboard>();
            speed = agentBlackboard.GetVariableValue<float>("speed");

        }

        //Called once per frame while the action is active.
        protected override void OnUpdate()
        {
            // pulls curent value, descrease it, then set value back on blackboard once the chagne is made
            float charge = agentBlackboard.GetVariableValue<float>("charge");
            charge -= chargeUseRate * Time.deltaTime;

            agentBlackboard.SetVariableValue("charge", charge);



            // moves the character to the target, no matter how far the distance is the same using .normalized
            Vector3 moveDirection = (target.position - agent.transform.position).normalized;
            agent.transform.position += moveDirection * speed * Time.deltaTime;

            float distanceToTarget = Vector3.Distance(target.position, agent.transform.position);
            if (distanceToTarget < arrivalDistance)
            {
                EndAction(true);
            }


        }

        //Called when the task is disabled.
        protected override void OnStop()
        {

        }

        //Called when the task is paused.
        protected override void OnPause()
        {

        }
    }
}