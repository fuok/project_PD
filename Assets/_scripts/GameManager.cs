using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Button btnShoot;
	public GameObject goShooter;

	public Text txtScore1, txtScore2;

	public static GameManager Instance {
		private set;
		get;
	}

	void Awake ()
	{
		if (!Instance) {
			Instance = this;
		}
	}

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
