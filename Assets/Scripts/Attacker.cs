using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {
	[Range(-1f, 1.5f)]
	public float currentSpeed;
	
	// Use this for initialization
	void Start () {
		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
		myRigidBody.isKinematic = true;
	}
	
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other.gameObject.tag);
		if(other.gameObject.tag == "Defender"){
			Debug.Log ("Attacking defender!");
		}else if(other.gameObject.tag == "Projectile"){
			Debug.Log ("Attacker hit by projectile!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}
	
	public void SetSpeed(float speed){
		currentSpeed = speed;
	}
	
	public void StrikeCurrentTarget(float damage){
		Debug.Log(gameObject.name + " has dealt " + damage + " damage!");
	}
}
