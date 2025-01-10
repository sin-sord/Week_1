using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class DebugAT : ActionTask {

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise

		// like Start() or Awake()
		protected override string OnInit() {
			// Initializing variable values
			// GetComponenets<>
			// Get initial position of a character
			// FindObject

			return null;
        }

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.

		// Called once we transition to that state
		protected override void OnExecute() {
			// setting a boolean at the start
			// Flipping character upside down
			// Setting dynamic variables that can change over time
			// resetting values when you jump into state

			// EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			// While state is active, action will always happen each frame

			//agent. is needed to access the objects components in the Inspector
			// ex:   agent.transform.position += agent.transform.position * 3f * Time.deltaTime;

        }

		//Called when the task is disabled.
		protected override void OnStop() {
			


		}

		//Called when the task is paused.
		protected override void OnPause() {
			


		}
	}
}