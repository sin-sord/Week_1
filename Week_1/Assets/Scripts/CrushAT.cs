using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class CrushAT : ActionTask {

		public Compactor compactor; //  holding where pressPad is and where animator is
		public float crushDuration;


		private float timeCrushing = 0f;

        public float chargeUseRate;

        private Blackboard agentBlackboard;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {


            agentBlackboard = agent.GetComponent<Blackboard>();


            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

			compactor.Crush();

			timeCrushing = 0;
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

			timeCrushing += Time.deltaTime;

            float charge = agentBlackboard.GetVariableValue<float>("charge");
            charge -= chargeUseRate * Time.deltaTime;

            agentBlackboard.SetVariableValue("charge", charge);


            if (timeCrushing > crushDuration)
			{
				EndAction(true);
				compactor.Stop();
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