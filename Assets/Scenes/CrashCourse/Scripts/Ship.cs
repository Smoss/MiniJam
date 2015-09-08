using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	Vector2 position;
	// Use this for initialization
	void Start () {
		position = new Vector2 (0.0f, Random.Range (-2.0f, 2.0f));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
