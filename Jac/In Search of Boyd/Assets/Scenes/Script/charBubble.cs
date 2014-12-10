using UnityEngine;
using System.Collections;

public class charBubble : MonoBehaviour {

	private float moveDistance = 2.768f;
	public float speed = 1f;
	Vector3 targetPosition = new Vector3(-6.7255f,13.4169f,0);
	public int level = 1;
	private float timer = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		timer += Time.deltaTime;

		if (level < 8) 
		{
			if (Input.GetKeyUp (KeyCode.UpArrow) && timer > 0.5) 
			{
				targetPosition = new Vector3 (transform.position.x, transform.position.y + moveDistance, transform.position.z);
				
				level++;
				timer = 0;
			}
		transform.position = Vector3.Lerp (transform.position, targetPosition, .1f);
		}

		if (level > 1) {

						if (Input.GetKeyUp (KeyCode.DownArrow) && timer > 0.5) {
								targetPosition = new Vector3 (transform.position.x, transform.position.y - moveDistance, transform.position.z);

								level --;
								timer = 0;
						}
						transform.position = Vector3.Lerp (transform.position, targetPosition, .1f);
				}
		//Application.LoadLevel (level.ToString());
	}	
}
