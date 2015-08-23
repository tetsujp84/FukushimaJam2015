using UnityEngine;
using System.Collections;

//敵の基底オブジェクト
[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour {

	//カメラ内に入っているか
	bool isInCamera=false;
	protected Rigidbody2D rigidbody;
	bool isRendered;
	Transform camera;
	 float minPositionY=-5;
	float distance=25f;
	// Use this for initialization
	void Start () {
		camera = GameObject.FindGameObjectWithTag ("MainCamera").transform;
		rigidbody = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (-camera.position.x + transform.position.x < distance) {
			transform.position=new Vector2(transform.position.x, Mathf.Clamp (transform.position.y, minPositionY, Mathf.Infinity));
			Move ();

			//Action ();
		}

	}

	//オーバーライドして動きをつける
	public virtual void Move(){
	}
	public virtual void Action (){

	}

	//カメラに入ったら動きはじめる

	/*private void OnWillRenderObject(){
		//メインカメラに映った時だけ_isRenderedを有効に
		if (Camera.current.tag == "MainCamera") {
			if (isRendered == false) {

				Move ();
				Action ();
			}
			isRendered = true;
		} else {
			isRendered = false;

		}
	}*/

}
