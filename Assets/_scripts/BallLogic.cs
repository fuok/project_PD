using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLogic : MonoBehaviour
{

	private Vector2 prevPos = new Vector2 (0, 0);
	private int stopStep = 0;

	//	void Start () {
	//
	//	}

	void Update ()
	{
		//if can't move any more, adding force
		Vector3 pos = transform.localPosition;
		if (prevPos.x == pos.x && prevPos.y == pos.y) {
			stopStep++;
			if (stopStep > 10) {
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (20, 20));
			}
		} else {
			stopStep = 0;			
		}

		prevPos = new Vector2 (pos.x, pos.y);
	}

	//when goal in box, SendMessage.
	void OnCollisionEnter2D (Collision2D col)
	{
		//Debug.Log(other.transform.tag);
//		if (col.transform.tag == "Floor") {
//			int box = 0;
//			switch (col.transform.name) {
//			case "Jackpot":
//				box = 5;
//				break;
//			case "Gold":
//				box = 4;
//				break;
//			case "Silver":
//				box = 3;
//				break;
//			case "Bronze":
//				box = 2;
//				break;
//			case "Lose":
//				box = 1;
//				break;
//			}
//			Destroy (gameObject);
//
//			Pinball_StartBtn startbtn = (Pinball_StartBtn)FindObjectOfType (typeof(Pinball_StartBtn));
//			startbtn.SendMessage ("GoalInBall", box);
//		}
	}
}
