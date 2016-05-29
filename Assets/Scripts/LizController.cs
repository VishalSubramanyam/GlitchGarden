using UnityEngine;
using System.Collections;

public class LizController : MonoBehaviour
{
	Animator animator;
	// Use this for initialization
	void Start ()
	{
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			var param = animator.GetBool ("isTalking");
			animator.SetBool ("isTalking", !param);
		}
	}
}
