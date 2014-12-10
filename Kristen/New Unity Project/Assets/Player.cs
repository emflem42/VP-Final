using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public string[] movements = new string[100];
	int counter1 = 0;
	string left = "left";
	string right = "right";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		addMovement (movements, left);
		addMovement (movements, right);
		clearArray (movements);
	}

	public void addMovement(string[] M, string s)
	{
		M [counter1] = s;
		Debug.Log ("ADDED STUFF");
		Debug.Log (movements [counter1]);
		counter1 ++;
	}

	public void clearArray(string[] M)
	{
		for(int i = 0; i<M.Length; i++)
		{
			M[i] = "";
		}
		counter1 = 0;
		Debug.Log ("ARRAY IS CLEAR");
	}

}
