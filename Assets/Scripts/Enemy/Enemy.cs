using UnityEngine;
using System.Collections;

//敵の基底オブジェクト
[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour {

	//カメラ内に入っているか
	bool isInCamera=false;
	public float speed;
	protected Rigidbody2D rigidbody;
	bool isRendered;
	// Use this for initialization
	void Start () {
	
		rigidbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isRendered == true) {
			Move ();
		}
	}
	//オーバーライドして動きをつける
	public virtual void Move(){
	}

	//カメラに入ったら動きはじめる

	private void OnWillRenderObject(){
		//メインカメラに映った時だけ_isRenderedを有効に
		if(Camera.current.tag == "MainCamera"){
			isRendered = true;
		}
	}

}
