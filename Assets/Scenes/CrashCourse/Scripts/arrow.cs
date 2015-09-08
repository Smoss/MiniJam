using UnityEngine;
using System.Collections;

public class arrow : MonoBehaviour {
	public Sprite none;
	public Sprite up;
	public Sprite left;
	public Sprite right;
	public Sprite down;
	bool state;
	float target;
	float last;
	// Use this for initialization
	void Start () {
		last = 0f;
		target = -1f;
		state = false;
	}
	
	// Update is called once per frame
	void Update () {
		last += Time.deltaTime;

		if(last >=1f)
		{
			if(target > 3f)
			{
				this.GetComponent<SpriteRenderer> ().sprite = up;
				if(state != GameObject.Find("Switch1").GetComponent<Switch1>().state)
				{
					this.GetComponentInParent<MiniGame>().ReportLose();
				}
			}
			else if(target > 2f)
			{
				this.GetComponent<SpriteRenderer> ().sprite = down;
				if(state != GameObject.Find("Switch2").GetComponent<Switch2>().state)
				{
					this.GetComponentInParent<MiniGame>().ReportLose();
				}
			}
			else if(target > 1f)
			{
				this.GetComponent<SpriteRenderer> ().sprite = left;
				if(state = GameObject.Find("Switch3").GetComponent<Switch3>().state)
				{
					this.GetComponentInParent<MiniGame>().ReportLose();
				}
			}
			else if(target > 0f)
			{
				this.GetComponent<SpriteRenderer> ().sprite = right;
				if(state = GameObject.Find("Switch4").GetComponent<Switch4>().state)
				{
					this.GetComponentInParent<MiniGame>().ReportLose();
				}
			}
			float temp = Random.Range (0f, 4f);
			target = temp; 
			if(temp > 3f)
			{
				this.GetComponent<SpriteRenderer> ().sprite = up;
				//state = GameObject.Find("Switch1").GetComponent<Switch1>().state;
			}
			else if(temp > 2f)
			{
				this.GetComponent<SpriteRenderer> ().sprite = down;
				//state = GameObject.Find("Switch2").GetComponent<Switch2>().state;
			}
			else if(temp > 1f)
			{
				this.GetComponent<SpriteRenderer> ().sprite = left;
				//state = GameObject.Find("Switch3").GetComponent<Switch3>().state;
			}
			else if(temp >0f);
			{
				this.GetComponent<SpriteRenderer> ().sprite = right;
				//state = GameObject.Find("Switch4").GetComponent<Switch4>().state;
			}
			
			last = 0f;
		}
	}
}
