using UnityEngine;
using System.Collections;

public class Mother : Singleton<Mother> {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {

			ScoreManager.Instance.SetGoal ();
		}
	}

}
