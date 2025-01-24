using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions
{

    public class VisibilityAT : ActionTask
    {


        Color visibilityAlpha;
        public float visibilityUseRate;
        private Blackboard agentBlackboard;
        private float speed;


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

            // references the objects blackboard
            agentBlackboard = agent.GetComponent<Blackboard>();
            speed = agentBlackboard.GetVariableValue<float>("speed");


        }

        //Called once per frame while the action is active.
        protected override void OnUpdate()
        {

                //  gets the objects visibility from the blackboard
                float visibility = agentBlackboard.GetVariableValue<float>("visibility");
                // visibility decreases over time
                visibilityAlpha.a -= Time.deltaTime;
                visibility -= visibilityUseRate * Time.deltaTime;

            agent.transform.position = Vector3.up;

          
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