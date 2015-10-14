using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	private AudioSource caitAA;
	public AudioClip turretSound;
	public AudioClip drakeSound;

	// Use this for initialization
	void Start () {
		caitAA = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Turret") {
			caitAA.PlayOneShot(turretSound, 2f);
		}
		if (col.gameObject.tag == "Drake") {
			caitAA.PlayOneShot(drakeSound, 0.3f);
		}
	}
}