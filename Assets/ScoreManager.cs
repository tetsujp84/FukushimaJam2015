using UnityEngine;
using System.Collections;
using System.Linq;

public class ScoreManager : Singleton<ScoreManager> {

	// Use this for initialization
	public int lifeGetCount;
	public int maxLifeCount;
	public GameObject loseText;
	void Start () {
		var obj = GameObject.FindGameObjectsWithTag ("Item");
		maxLifeCount = obj.Count();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SetGoal(){
		if (lifeGetCount == maxLifeCount) {
			GameManager.Instance.GoNextScene ("ClearScene");
		} else {
			GameManager.Instance.GoNextScene ("ClearSubScene");
		}
	}

	public void SetLose(){
		loseText.SetActive (true);
		Invoke("Retry",2f);
	}
	public void Retry(){

		GameManager.Instance.GoNextScene (Application.loadedLevelName);

	}
}
