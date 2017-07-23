using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinAnime : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		print ("haha");
		GetComponent<Animator>().SetTrigger("flash");
	}
}
