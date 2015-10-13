using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class moveControl : MonoBehaviour {

	private float lureHeight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A)) {
			GetComponent<Rigidbody> ().AddForce (-5, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			GetComponent<Rigidbody> ().AddForce (0, 0, -5);
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			GetComponent<Rigidbody> ().AddForce (0, 0, 5);
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			GetComponent<Rigidbody> ().AddForce (5, 0, 0);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			GetComponent<Rigidbody> ().AddForce (0, -100, 0);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody> ().AddForce (0, 100, 0);
		}
	
	}

}
