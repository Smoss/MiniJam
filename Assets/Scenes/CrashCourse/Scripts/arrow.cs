using UnityEngine;
using System.Collections;

public class arrow : MonoBehaviour {
	public Sprite none;
	public Sprite up;
	public Sprite left;
	public Sprite right;
	public Sprite down;
	bool state;
	float last;
	// Use this for initialization
	void Start () {
		last = 0f;

	}
	
	// Update is called once per frame
	void Update () {
		last = Time.deltaTime;

		if(last >=2f)
		{
			float temp = Random.Range (0f, 4f);
			if(temp > 3f)
			{
				this.GetComponent<SpriteRenderer> ().sprite = up;
			}
			else if(temp > 2f)
			{
				this.GetComponent<SpriteRenderer> ().sprite = down;
			}
			else if(temp > 1f)
			{
				this.GetComponent<SpriteRenderer> ().sprite = left;
			}
			else
			{
				this.GetComponent<SpriteRenderer> ().sprite = right;
			}
		}

		last = 0f;
	}
}
