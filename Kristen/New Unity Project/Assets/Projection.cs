using UnityEngine;
using System.Collections;

public class Projection : MonoBehaviour {

	public GameObject myPlayer;
	public Player playerScript;

	// Use this for initialization
	void Start () {
		playerScript = myPlayer.GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public void getMovement(string[] M)
	{
		for (int i = 0; i<M.Length; i++) 
		{

		}
	}

}
