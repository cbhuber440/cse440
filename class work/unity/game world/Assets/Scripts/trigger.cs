using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	void OnTriggerEnter2D( Collider2D other )
	{
		Debug.Log ("You reached the top!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
