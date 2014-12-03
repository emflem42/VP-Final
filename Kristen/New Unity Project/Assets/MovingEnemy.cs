﻿using UnityEngine;
using System.Collections;
using System.Timers;

public class MovingEnemy : MonoBehaviour {

	public Vector2 position;
	public Vector2 targetPosition;
	public float t =  0;
	bool movedRight = false;
	bool movedUp = false;
	bool movedDown = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		t += Time.deltaTime;
		if (t >= 3 && !movedRight )
		{
			moveRight(3);
			Debug.Log ("I SHOULD MOVE RIGHT");
			movedRight = true;
		}

		if (t >= 7 && !movedUp) 
		{
			moveUp(3);	
			Debug.Log ("I SHOULD MOVE UP");
			movedUp = true;
		}

		if (t>= 11 && !movedDown)
		{
			moveDown (3);
			movedDown = true;
		}

		if (t>=16)
		{
			moveLeft(3);
			movedRight = false;
			movedUp = false;
			movedDown = false;
			t= 0;
		}

	}

	//the input controls how far the character moves 
	public void moveRight(float num)
	{
		targetPosition = new Vector2 (this.transform.position.x + num, this.transform.position.y);
		transform.position = Vector2.Lerp (transform.position, targetPosition, .4f);
	}

	public void moveLeft(float num)
	{
		targetPosition = new Vector2 (transform.position.x - num, transform.position.y);
		transform.position = Vector2.Lerp (transform.position, targetPosition, .4f);
	}

	public void moveUp(float num)
	{
		targetPosition = new Vector2 (this.transform.position.x, this.transform.position.y + num);
		transform.position = Vector2.Lerp (transform.position, targetPosition, .4f);
	}

	public void moveDown(float num)
	{
		targetPosition = new Vector2 (transform.position.x, transform.position.y - num);
		transform.position = Vector2.Lerp (position, targetPosition, .4f);
	}

	public void wait(int num)
	{
			targetPosition = new Vector2 (transform.position.x, transform.position.y);
			transform.position = Vector2.Lerp (position, targetPosition, .2f);
	}

}
