using UnityEngine;
using System.Collections;

public class Gun2 : MonoBehaviour {

	public GameObject claw;
	public bool isShooting;
	public Animator minerAnimator;
	public Claw clawScript;

	//private Vector3 origin = transform;


	void Update () 
	{
		if (Input.GetButtonDown("Fire1") && !isShooting)
		{
			LaunchClaw();
		}

	}

	void LaunchClaw()
	{
		isShooting = true;
		minerAnimator.speed = 0;
	//	renderer.enabled = false;
		GetComponent<Renderer> ().enabled = false;

		RaycastHit hit;
		Vector3 down = transform.TransformDirection(Vector3.down);

		if(Physics.Raycast(transform.position, down, out hit, 100))
		{
			claw.SetActive(true);
			clawScript.ClawTarget(hit.point);
		}
	}

	public void CollectedObject()
	{
		isShooting = false;
		minerAnimator.speed = 1;
		GetComponent<Renderer> ().enabled = true;
	}
}