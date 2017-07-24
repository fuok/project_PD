using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{


	void OnBecameInvisible ()
	{
		Destroy (gameObject, 0.5f);
	}

}
