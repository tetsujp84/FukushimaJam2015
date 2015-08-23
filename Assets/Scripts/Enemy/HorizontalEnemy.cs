using UnityEngine;
using System.Collections;

public class HorizontalEnemy : Enemy {

	// Use this for initialization
	public float speed;
	public override void Move(){
		rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
	}
}
