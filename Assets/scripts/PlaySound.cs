using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	private AudioSource caitAA;
	public AudioClip source;

	// Use this for initialization
	void Start () {
		caitAA = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Turret") {
			caitAA.PlayOneShot(source, 1f);
		}
	}
}