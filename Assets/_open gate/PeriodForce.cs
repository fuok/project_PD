using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeriodForce : MonoBehaviour
{

	public HingeJoint2D hj1, hj2;

	public bool open;

	private float openTime = 1f;
	private float closeTime = 2f;
	private float mForce = 200f;
	//如果速度不够快会出现speed数值改变但不触发运动的情况，也就是说如果joint在运动中，修改速度是无效的，必须要joint静止


	// Use this for initialization
	void Start ()
	{
		ChangeForce ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	//	private IEnumerator ChangeForce (float delta)
	//	{
	//
	//	}

	private void ChangeForce ()
	{
		//
		JointMotor2D motor1 = hj1.motor;
		motor1.motorSpeed = open ? mForce : (mForce * -1);
		hj1.motor = motor1;
		//
		JointMotor2D motor2 = hj2.motor;
		motor2.motorSpeed = open ? (mForce * -1) : mForce;
		hj2.motor = motor2;

		Invoke ("ChangeForce", open ? openTime : closeTime);

		open = !open;
	}
}
