using UnityEngine;
using System.Collections;

//横にのみ移動する敵
public class VerticalEnemy : Enemy {

	public override void Move(){
		rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
		}
}
