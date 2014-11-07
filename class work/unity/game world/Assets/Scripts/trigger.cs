using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	void onTriggerEnter2d( Collider2D other )
	{
		Debug.Log ("You reached the top!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
