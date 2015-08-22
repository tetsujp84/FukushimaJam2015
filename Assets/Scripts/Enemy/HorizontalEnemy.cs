using UnityEngine;
using System.Collections;

public class HorizontalEnemy : Enemy {

	// Use this for initialization

	public override void Move(){
		rigidbody.velocity = new Vector2(0, speed);
	}
}
