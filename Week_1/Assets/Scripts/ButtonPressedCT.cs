using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class ButtonPressedCT : ConditionTask {


		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {

			Debug.Log("Cube is coming to button");

        }

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {

			//  if the spacebar is pressed return true..
			if (Input.GetKeyDown(KeyCode.Space))
			{
				return true;
              
            }
			else
			{
				// else return false...
				return (false);
			}

		}
	}
}