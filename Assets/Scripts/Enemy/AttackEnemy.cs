using UnityEngine;
using System.Collections;

public class AttackEnemy : Enemy {

	// Use this for initialization
	GameObject weapon;
	public float speed;
	public float intervalTime;
	public float oldTime;
	void Awake () {
		weapon=Resources.Load<GameObject>("NawaWeapon");
		oldTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		

	}



	public override void Move(){
		rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
	}
	/*public override void Action(){
		
		if (Time.time - oldTime > intervalTime) {
			Instantiate (weapon, transform.position, Quaternion.identity);
			oldTime = Time.time;
		}
	}*/

	//animationからよぶ
	public void Attack(){
		Instantiate (weapon, transform.position, Quaternion.identity);
}
}