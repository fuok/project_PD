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
		if (col.transform.tag == "Floor") {
//			int box = 0;
			switch (col.transform.parent.name) {
			case "Prize Gate 1":
				print ("11111");
				Constants.SCORE_1++;
				GameManager.Instance.txtScore1.text = Constants.SCORE_1.ToString ();
				break;
			case "Prize Gate 2":
				print ("22222");
				Constants.SCORE_2++;
				GameManager.Instance.txtScore2.text = Constants.SCORE_2.ToString ();
				break;
			}
			Destroy (gameObject);

//			Pinball_StartBtn startbtn = (Pinball_StartBtn)FindObjectOfType (typeof(Pinball_StartBtn));
//			startbtn.SendMessage ("GoalInBall", box);
		}
	}
}
