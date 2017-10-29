using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float health;
	
	public void DealDamage(float damage){
		health -= damage;
		if (health <= 0){
			//animate death, move method to animator
			DestroyObject();
		}
	}
	
	//to be called from animator at the end of death animation
	public void DestroyObject(){
		Destroy(gameObject);
	}
}
