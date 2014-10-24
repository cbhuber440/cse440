using UnityEngine;
using System.Collections;

public class spriteChange : MonoBehaviour {
	public Sprite sprite1;
	public Sprite sprite2;
	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			if (sr.sprite == sprite1) {
				sr.sprite = sprite2;
			} else {
				sr.sprite = sprite1;
			}
		}
	}
}
