using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {
 	private GameObject currentTarget;
	private Health targetHealth;
	private Animator animator;
	private float currentSpeed;
	
	// Use this for initialization
	void Start () {
		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
		myRigidBody.isKinematic = true;
		
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
		if(!currentTarget){
			animator.SetBool("isAttacking", false);
		}
	}
	
	public void SetSpeed(float speed){
		currentSpeed = speed;
	}
	
	//When attacker isAttacking, set target to damage
	public void Attack(GameObject obj){
		currentTarget = obj;
	}
	
	//actually talks to target's health to deal damage. called from animator
	public void StrikeCurrentTarget(float damage){
		//Debug.Log(gameObject.name + " has dealt " + damage + " damage to the " + currentTarget.name);
		if(currentTarget){
			Health health = currentTarget.GetComponent<Health>();
			if(health){
				health.DealDamage(damage);
			}
		}
	}
}
