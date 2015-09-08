using UnityEngine;
using System.Collections;

public class Switch4 : MonoBehaviour {
	public Sprite on;
	public Sprite off;
	public bool state=false;
	bool swapped;
	// Use this for initialization
	void Start () {
		state = true;
		if (Random.Range (-1.0f, 1.0f) > 0) {
			this.GetComponent<SpriteRenderer> ().sprite = on;
			state = true;
		} else {
			this.GetComponent<SpriteRenderer> ().sprite = off;
			state = false;
		}
		swapped = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Horizontal")>0 && !swapped) {
			state = !state;
			swapped = true;
			if(state)
			{
				this.GetComponent<SpriteRenderer> ().sprite = on;
			}	
			else{
				this.GetComponent<SpriteRenderer> ().sprite = off;
			}
			
		}
		else if(Input.GetAxis ("Horizontal")>0 && swapped){
		}
		else{
			swapped = false;
		}
	}
}
