using UnityEngine;
using System.Collections;

public class BallShooter : MonoBehaviour
{

	public GameObject _pinball;
	public Vector3 mDirection;
	public float mPower = 120f;
	// Use this for initialization
	void Start ()
	{
	}

	public void GameStart (int ballnum)
	{
		StartCoroutine (Shoot (ballnum));		
	}

	IEnumerator Shoot (int count)
	{
		for (int i = 0; i < count; i++) {
			int forceX = UnityEngine.Random.Range (-0, -200);
			int forceY = UnityEngine.Random.Range (50, 100);

			GameObject ball = (GameObject)Instantiate (_pinball, transform.position, Quaternion.identity);
//			ball.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (forceX, forceY));
			ball.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (mDirection.x, mDirection.y) * mPower * Random.Range (0.9f, 1.1f));
			yield return new WaitForSeconds (0.5f);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnDrawGizmos ()
	{
//		print("haha");
		Gizmos.color = Color.red;
		Gizmos.DrawRay (transform.position, mDirection);
	}
}
