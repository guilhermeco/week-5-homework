using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {

	private Transform startPoint, endPoint;
	Transform lurePosition;
	
	public float percentage;
	public float speed;
	private int direction;
	public GameObject PUBLICGAMEOBJECT;


	// Use this for initialization
	void Start () {

	lurePosition = GameObject.Find ("Lure").transform;
	startPoint = GameObject.Find ("startPoint").transform;
	endPoint = GameObject.Find ("endPoint").transform;
		direction = 1;
	}
	
	// Update is called once per frame
	void Update () {

		speed = Random.Range (1, 10);
		transform.position = Vector3.Lerp (startPoint.position, endPoint.position, percentage);
		percentage += Time.deltaTime/speed * direction;

			if ((percentage > 1) || (percentage < 0)) {
				direction = -direction;
				percentage = Mathf.Clamp(percentage, 0, 1);
			}
	}

	void OnTriggerEnter (Collider other) {
		gameObject.transform.parent = PUBLICGAMEOBJECT.transform;
		gameObject.GetComponent<mover> ().enabled = false;

	}
}
