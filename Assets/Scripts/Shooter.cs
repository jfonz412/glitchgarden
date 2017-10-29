using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public GameObject projectile, projectileParent, gun;
	
	//animator can reach into private methods
	private void Fire(){
		GameObject newProjectile = Instantiate(projectile) as GameObject;
		newProjectile.transform.SetParent(projectileParent.transform);
		newProjectile.transform.position = gun.transform.position;	
	}
}
