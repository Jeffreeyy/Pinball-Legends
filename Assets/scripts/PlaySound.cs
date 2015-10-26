using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {
	
	private AudioSource sound;
	[SerializeField]private GameObject toggle;
	[SerializeField]private GameObject GA;
	[SerializeField]private AudioClip turretSound;
	[SerializeField]private AudioClip drakeSound;
	[SerializeField]private AudioClip reviveSound;

	// Use this for initialization
	void Start () {
		sound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Turret") {
			sound.PlayOneShot(turretSound, 2f);
		}
		if (col.gameObject.tag == "Drake") {
			sound.PlayOneShot(drakeSound, 0.3f);
		}
		if (col.gameObject.tag == "GuardianAngel") {
			sound.PlayOneShot(reviveSound, 0.3f);
			Destroy(col.gameObject);
			scoreCount.GuardianAngel = false;
			toggle.SetActive(!toggle.activeSelf);
		}
	}
}