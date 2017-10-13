using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fade : MonoBehaviour {
	public float fadeTime = 3.0f;
	
	private Image fadePanel;
	private Color currentColor = Color.black;

	// Use this for initialization
	void Start () {
		fadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		FadeIn();
	}
	
	void FadeIn(){
		if (Time.timeSinceLevelLoad < fadeTime){
			float alphaChangePerFrame = Time.deltaTime / fadeTime;
			currentColor.a -= alphaChangePerFrame;
			fadePanel.color = currentColor;
		}
		else {
			//deactivate object once fade is finished
			gameObject.SetActive(false);
		}
	}
}
