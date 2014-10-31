using UnityEngine;
using System.Collections;

public class keyboardInput : MonoBehaviour {
	public float moveSpeed = .05f;

	void Update () {
		Vector3 tempPosition = transform.position;
		if (Input.GetAxis ("Horizontal") > 0) {
			tempPosition.x += moveSpeed;
		} 
		if (Input.GetAxis ("Horizontal") < 0) {
			tempPosition.x -= moveSpeed;
		}
		if (Input.GetAxis ("Vertical") > 0) {
			tempPosition.y += moveSpeed;
		}
		if (Input.GetAxis ("Vertical") < 0) {
			tempPosition.y -= moveSpeed;
		}
		transform.position = tempPosition;
	}
}
