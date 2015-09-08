using UnityEngine;
using System.Collections;

public class Wheel : MonoBehaviour {
	
	public float speed = 1.0f;
	public string axisName = "Horizontal";
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButton("Button 1")) {
			// left
			transform.Rotate(0.0f, 0.0f, 5.0f);  // does nothing, just a bad guess
		}
		
		if(Input.GetButton("Button 2")) {
			// right
			transform.Rotate(0.0f, 0.0f, -5.0f);  // does nothing, just a bad guess
		}
		
	}
}
