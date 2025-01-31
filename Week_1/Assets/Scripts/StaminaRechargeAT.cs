using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class StaminaRechargeAT : ActionTask {

		public float staminaRechargeRate;
		public float maxStamina;
        public BBParameter<float> staminaRecharge;
        public BBParameter<GameObject> chargerPad;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
           
			// grabs other variable from another FSM object, string can be used to say (in this case) "we are charging at [string value]"
            Blackboard staminaRechargePad = chargerPad.value.GetComponent<Blackboard>();
            
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

            staminaRecharge.value += staminaRechargeRate * Time.deltaTime;

            if (staminaRecharge.value >= maxStamina)
            {
                staminaRecharge.value = maxStamina;
                EndAction(true);
            }
        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}