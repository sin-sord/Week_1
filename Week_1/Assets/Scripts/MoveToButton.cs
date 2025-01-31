using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

    public class MoveToButton : ActionTask {

        public BBParameter<Transform> directionMovingIn;
		public float speed;
        public float arrivalDistance;

		public BBParameter<Transform> buttonTransform;
		public  Blackboard chargerTransform;
		public float staminaUseRate;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			
			
			
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

            chargerTransform = agent.GetComponent<Blackboard>();
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

			//  Get the transform of the button so that the GameObject moves towards it
			Blackboard buttonLocation = buttonTransform.value.GetComponent<Blackboard>();

            float stamina = chargerTransform.GetVariableValue<float>("stamina");
            stamina -= staminaUseRate * Time.deltaTime;

            chargerTransform.SetVariableValue("stamina", stamina);


			//  Fix line is saying that the character doesn't know where to go

            //  grabs the Blackboards of the buttons and says which button it's moving to
			

			//  the movement part to have the box move to the buttons
            Vector3 arriveAtButton = (buttonTransform.value.position - agent.transform.position).normalized;
            agent.transform.position += arriveAtButton *  speed * Time.deltaTime;


            float distanceToButton = Vector3.Distance(agent.transform.position, buttonTransform.value.position);


			//  if the distance to the button is less than the arrival distance then end the action
            if (distanceToButton < arrivalDistance)
            {
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