using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public GameObject projectile, gun;
	private GameObject projectileParent;
	
	void Start(){
		projectileParent = GameObject.Find("Projectiles");
		if(!projectileParent){
			projectileParent = new GameObject("Projectiles");
		}
	}
	
	//animator can reach into private methods
	private void Fire(){
		GameObject newProjectile = Instantiate(projectile) as GameObject;
		newProjectile.transform.SetParent(projectileParent.transform);
		newProjectile.transform.position = gun.transform.position;	
	}
}
