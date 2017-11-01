using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {
	public Camera myCamera;
	
	private GameObject defenderParent;
	
	void Start(){
		defenderParent = GameObject.Find("Defenders");
		if(!defenderParent){
			defenderParent = new GameObject("Defenders");
		}
	}
	
	void OnMouseDown(){
		SpawnDefender();
	}
	
	void SpawnDefender(){
		Vector2 rawPos = WorldPositionOfMouseClick();
		Vector2 pos    = RoundCoordinates(rawPos);
		GameObject defender = Button.selectedObject;
		Quaternion zeroRot = Quaternion.identity;
		GameObject newDef = Instantiate(defender, pos, zeroRot) as GameObject;
		
		newDef.transform.parent = defenderParent.transform;
	}
	
	Vector2 RoundCoordinates( Vector2 rawCoordinates){
		float newX = Mathf.RoundToInt(rawCoordinates.x);
		float newY = Mathf.RoundToInt(rawCoordinates.y);
		return new Vector2(newX, newY);
	}
	
	Vector2 WorldPositionOfMouseClick(){
		float x = Input.mousePosition.x;
		float y = Input.mousePosition.y;
		float distanceFromCamera = 10f;
		
		//"Transforms position from screen space into world space."
		//The screen is in pixels, mouse input returns pixel coordinates
		//This method takes the mouse's pixel coordinates and the distance from
		//The camera to the unity world and translates it the same coordinates
		//you see while you are editing a scene.
		
		//The UI or canvas (grass image) in this game has been turned into 
		//"World space" as well. Canvas' are usually in pixel scale as well.
		Vector3 weirdTriplet = new Vector3(x,y,distanceFromCamera);
		Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);
		return worldPos;
	}
}
