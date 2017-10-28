using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {
 	private GameObject currentTarget;
	private float currentSpeed;
	
	// Use this for initialization
	void Start () {
		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
		myRigidBody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}
	
	public void SetSpeed(float speed){
		currentSpeed = speed;
	}
	
	public void Attack(GameObject obj){
		currentTarget = obj;
	}
	
	public void StrikeCurrentTarget(float damage){
		Debug.Log(gameObject.name + " has dealt " + damage + " damage!");
	}
}
