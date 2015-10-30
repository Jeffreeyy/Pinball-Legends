using UnityEngine;
using System.Collections;

public class GuardianAngel : MonoBehaviour {

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
		if (scoreCount.score >= 5000 && scoreCount.GuardianAngel == false) {
			kaChing.Play();
			toggle.SetActive(!toggle.activeSelf);
			scoreCount.score = scoreCount.score - 10000;
			scoreCount.GuardianAngel = true;
			GA_Effect.GuardianAngelEffect = true;
		}
	}
}