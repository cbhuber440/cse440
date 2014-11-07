using UnityEngine;
using System.Collections;

public class keyboardInput : MonoBehaviour {
	public float moveSpeed;
	public float jumpSpeed;
	public float mVelocity;
	private float Magnitude;
	private bool jump = false;

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "floor") {
			jump = true;
		}
	}

	/* void Jump() {
		animation.Play ("jump");
		rigidbody.AddForce (Vector3.up * jumpSpeed);
	}*/

	void FixedUpdate () {
		Magnitude = rigidbody2D.velocity.magnitude;

		if (Input.GetButtonDown ("Jump") && jump) {
			rigidbody2D.AddForce (Vector3.up * jumpSpeed);
			jump = false;
		}
		if (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") > 0)
		{
			if (Magnitude < mVelocity) {
				rigidbody2D.AddForce(Vector3.right * moveSpeed * Time.deltaTime);
			}
		}
		if (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") > 0)
		    {
			if (Magnitude < mVelocity) {
				rigidbody2D.AddForce(Vector3.left * moveSpeed * Time.deltaTime);
			}
		}
	}

	void Update () {
		/*Vector3 tempPosition = transform.position;
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
		if (Input.GetButtonDown ("Jump")) {
			Jump ();
		}
		transform.position = tempPosition;
		*/
	}
}
