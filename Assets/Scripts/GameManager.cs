using UnityEngine;
using System.Collections;

public class GameManager : DontDestroySingleton<GameManager> {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoNextScene(string nextScene){
		FadeManager.Instance.LoadLevel (nextScene, 1f);
	}

}
