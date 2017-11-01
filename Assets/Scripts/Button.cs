using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public static GameObject selectedObject;
	
	public GameObject defender;

	private Button[] buttonArray;

	// Use this for initialization
	void Start () {
		buttonArray = GameObject.FindObjectsOfType<Button>(); //finds all objects of type button 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown(){
		foreach(Button thisButton in buttonArray){
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;
		}
		GetComponent<SpriteRenderer>().color = Color.white;
		selectedObject = this.defender; // just being explicit
		Debug.Log (selectedObject);
	}
}
