using UnityEngine;
using System.Collections;

public class lizMove : StateMachineBehaviour
{
	public float speed = 0.5f;
	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	//override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		if (animator.gameObject.transform.position.x < 0 || animator.gameObject.transform.position.x > 10) {
			Vector3 theRotationAngle = animator.gameObject.transform.rotation.eulerAngles;
			theRotationAngle.y += 180f;
			animator.gameObject.transform.rotation = Quaternion.Euler (theRotationAngle);
			animator.gameObject.GetComponent<Transform> ().Translate (new Vector3 (speed * Time.deltaTime - 0.3f, 0f, 0f));
		} else {
			animator.gameObject.GetComponent<Transform> ().Translate (new Vector3 (-speed * Time.deltaTime, 0f, 0f));
		}
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
