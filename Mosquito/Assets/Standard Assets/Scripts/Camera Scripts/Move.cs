using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public Transform target;
	public int r;
	int x, y, x1, y1, a;

	// Use this for initialization
	void Start () {
		x = target.position.x;
		y = target.position.y;
		x1 = this.transform.position.x;
		y1 = this.transform.position.y;

		if (x < x1) 
		{
			x1 = x - (x1 - x);
		}
		if (x > x1) 
		{
			x1 = x + (x - x1);
		}

		if (y < y1) 
		{
			y1 = y - (y1 - y);
		}
		if (y > y1) 
		{
			y1 = y + (y - y1);
		}

		a = 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}