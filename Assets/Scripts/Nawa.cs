using UnityEngine;
using System.Collections;

public class Nawa : MonoBehaviour {

	Rigidbody2D rigidbody;
	public float speed;
	public float existTime;//縄が先に行くまでの時間
	float nawaMiddleSize=3;
	GameObject nawaMiddle;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
		rigidbody.velocity = new Vector2 (speed,0);
		nawaMiddle = Resources.Load<GameObject> ("NawaMiddleWeapon");
		StartCoroutine ("CreateMiddle");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator CreateMiddle(){
		var startTime = Time.time;

		//前半
		while(true){
			yield return new WaitForSeconds (nawaMiddleSize/Mathf.Abs(speed));
			var obj=Instantiate (nawaMiddle, transform.position, Quaternion.identity);
			Destroy(obj,(startTime+existTime-Time.time)*2);
			if (Time.time - startTime > existTime) {
				break;
			}
			}
		startTime = Time.time;
		rigidbody.velocity = new Vector2 (-speed, 0);
		while(true){
			//Instantiate (nawaMiddle, transform.position, Quaternion.identity);
			if (Time.time - startTime > existTime) {
				break;
			}
			yield return new WaitForSeconds (nawaMiddleSize/Mathf.Abs(speed));
		}
		Destroy (gameObject);


	}
}
