using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {

	// Use this for initialization
	GameObject wheel;
	Vector3 position;
	float currentTime =0;
	void Start () {
		wheel = GameObject.Find ("wheel");
		position = new Vector3 (Random.Range (-5.0f, 5.0f),0.0f ,0.0f);
		transform.position = position + transform.position;
		
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = (Time.deltaTime*new Vector3(0.2f, 0.2f, 0.0f))+transform.localScale;  // does nothing, just a bad guess
		transform.position = (Time.deltaTime*new Vector3 (wheel.GetComponent<Wheel>().rot/360.0f,0.0f ,0.0f)) + transform.position;
		transform.position = (Time.deltaTime*new Vector3 (Random.Range (-15f, 15f),0.0f ,0.0f)) + transform.position;
		currentTime += Time.deltaTime;
		if (currentTime>9.0f) {
			if(transform.position.x<5.0)
			{
				this.GetComponentInParent<MiniGame>().ReportWin();
			}
		}

	
	}
}
