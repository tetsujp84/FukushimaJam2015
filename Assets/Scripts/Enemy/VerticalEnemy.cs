using UnityEngine;
using System.Collections;

//たてにのみ移動する敵
public class VerticalEnemy : Enemy {
	public float speed;
	public float oldTime;
	public float intervalTime;
	public void Awake(){
		oldTime = Time.time;
	}
	public override void Move(){
		if(Time.time - oldTime > intervalTime)	{

			rigidbody.AddForce(Vector2.up * speed);
			oldTime=Time.time;
		}
	}

}
