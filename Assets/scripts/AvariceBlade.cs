using UnityEngine;
using System.Collections;

public class AvariceBlade : MonoBehaviour {

	public GameObject toggle;
	private AudioSource kaChing;
	// Use this for initialization

	void Start () {
		kaChing = GetComponent<AudioSource> ();
		toggle.SetActive (!toggle.activeSelf);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnMouseDown(){
		if (scoreCount.score >= 1200 && scoreCount.AvariceBlade == false) {
			kaChing.Play();
			toggle.SetActive (!toggle.activeSelf);
			scoreCount.score = scoreCount.score - 1200;
			scoreCount.AvariceBlade = true;
		}
	}
}
