using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class PressedAT : ActionTask {

		float pressedDown = 0.5f;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
         

            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
                

        }

        //Called once per frame while the action is active.
        protected override void OnUpdate() {


			// if the spacebar is pressed...
			if(Input.GetKeyDown(KeyCode.Space))
			{
				//  move the button down on the y-axis by 0.5f
				agent.transform.position = new Vector3(agent.transform.position.x, agent.transform.position.y - pressedDown, 0);
               

            }
			else
			{
				//  else move it up by 0.5f, then end the action
                agent.transform.position = new Vector3(agent.transform.position.x, agent.transform.position.y + pressedDown, 0);
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