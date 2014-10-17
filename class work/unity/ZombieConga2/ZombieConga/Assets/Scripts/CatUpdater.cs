using UnityEngine;

public class CatUpdater : MonoBehaviour {

	private CatController catController;

	void OnBecameInvisible() {
		catController.OnBecameInvisible ();
	}

	void GrantCatTheSweetReleaseOfDeath() {
		Destroy (transform.parent.gameObject);
	}

	// Use this for initialization
	void Start () {
		catController = transform.parent.GetComponent<CatController>();
	}
	
	// Update is called once per frame
	void Update () {
		catController.UpdateTargetPosition();
	}
}
