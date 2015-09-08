using UnityEngine;
using System.Collections;

public class Wheel : MonoBehaviour {
	
	public float speed = 1.0f;
	public float rot;
	
	// Use this for initialization
	void Start () {
		rot = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButton("Button 1")) {
			// left
			transform.Rotate(Time.deltaTime*new Vector3(0.0f, 0.0f, 600.0f));  // does nothing, just a bad guess
			rot = rot + Time.deltaTime*1200.0f;
		}
		
		if(Input.GetButton("Button 2")) {
			// right
			transform.Rotate(Time.deltaTime*new Vector3(0.0f, 0.0f, -600.0f));  // does nothing, just a bad guess
			rot = rot + Time.deltaTime*-1200.0f;
		}
		
	}
}
