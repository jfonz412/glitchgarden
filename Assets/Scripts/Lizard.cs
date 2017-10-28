using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Lizard : MonoBehaviour {	
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
		}else{
			animator.SetBool("isAttacking", true);
			attacker.Attack(obj);
		}
	}
}
