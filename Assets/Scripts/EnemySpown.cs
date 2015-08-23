using UnityEngine;
using System.Collections;

public class EnemySpown : MonoBehaviour {

	public GameObject enemyObject;
	Transform camera;
	public float distance;//生成開始する処理
	float destroyDistance=5f;
	public float intervalTime;
	// Use this for initialization
	void Start () {

		camera = GameObject.FindGameObjectWithTag ("MainCamera").transform;

		StartCoroutine ("Create");
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	IEnumerator Create(){
		while (true) {
			if (distance > (transform.position.x-(camera.position.x))) {
				Instantiate (enemyObject, transform.position, Quaternion.identity);

			}
			yield return new WaitForSeconds (intervalTime);
			if (transform.position.x < camera.position.x+destroyDistance) {
				Destroy (gameObject);
			}
		}
	}
}
