using UnityEngine;
using System.Collections;

public class mover3 : MonoBehaviour {
	
	private Transform startPoint3, endPoint3;
	
	public float percentage;
	public float speed = 1;
	private int direction;
	
	// Use this for initialization
	void Start () {
		
		startPoint3 = GameObject.Find ("startPoint3").transform;
		endPoint3 = GameObject.Find ("endPoint3").transform;
		direction = 1;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = Vector3.Lerp (startPoint3.position, endPoint3.position, percentage);	
		percentage += Time.deltaTime/speed * direction;
		
		if ((percentage > 1) || (percentage < 0)) {
			direction = -direction;
			percentage = Mathf.Clamp (percentage, 0, 1);
		}
		
	}
}