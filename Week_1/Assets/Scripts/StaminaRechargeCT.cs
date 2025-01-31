using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class StaminaRechargeCT : ConditionTask {

        public string staminaVariable;
        public float threshold;

        private Blackboard staminaBlackboard;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){

            staminaBlackboard = agent.GetComponent<Blackboard>();
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

            float value = staminaBlackboard.GetVariableValue<float>(staminaVariable);
            bool meetsThreshold = value > threshold;


            return meetsThreshold;
        }
	}
}