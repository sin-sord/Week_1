using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions
{

    public class VisibilityAT : ActionTask
    {

        public float visibilityUseRate;
        private Blackboard agentBlackboard;

        public float value;
        public Material sprite;
        Color visibility;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit()
        {
            visibility = sprite.color;
            return null;
        }

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute()
        {

            //  gets the blackboards variable "visibility"
            float visibility = agentBlackboard.GetVariableValue<float>("visibility");
         
            //  value of the variable decreases each frame
            visibility -= visibilityUseRate * Time.deltaTime;
          
            //  updates the value of the variable
            agentBlackboard.SetVariableValue("visibility", visibility);

        }

        //Called once per frame while the action is active.
        protected override void OnUpdate()
        {

            visibility.a = value / 255;
            sprite.color = visibility;

            EndAction(true);
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