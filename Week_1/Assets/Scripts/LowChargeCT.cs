using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


namespace NodeCanvas.Tasks.Conditions {

	public class LowChargeCT : ConditionTask {

        public string variableName;
        public float threshold;

        private Blackboard agentBlackboard;


        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){

            agentBlackboard = agent.GetComponent<Blackboard>();

            return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {

            
        }

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {

            float value = agentBlackboard.GetVariableValue<float>(variableName);
            bool isUnderThreshold = value < threshold;


            return isUnderThreshold;
		}
	}
}