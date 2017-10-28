using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Fox : MonoBehaviour {	
	private Animator animator;
	private Attacker attacker;
	
	void Start(){
		animator = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}

	void OnTriggerEnter2D(Collider2D other){
		GameObject obj = other.gameObject;
		if (!obj.GetComponent<Defender>()){
			return;
		}
		
		if (obj.GetComponent<Stone>() && obj.GetComponent<Defender>()){
			animator.SetTrigger("Jump Trigger");
		} else{
			animator.SetBool("isAttacking", true);
			attacker.Attack(obj);
		}
	}
}
