using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour {

	private bool _Reset = false;
	private Rigidbody rb;
	public AudioSource kickSound;
	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();
		kickSound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		CheckSpringKey ();
	}

	private void CheckSpringKey()
	{
		if(Input.GetKeyDown (KeyCode.Space))
		{
			UseSpring ();
			_Reset = true;
		}
		if(Input.GetKeyUp (KeyCode.Space) && _Reset)
		{
			ResetSpring();
			_Reset = false;
			
		}
	}

	private void UseSpring()
	{
		rb.AddForce(transform.forward * 75f, ForceMode.Impulse);
		kickSound.Play ();
	}

	private void ResetSpring()
	{
		if(_Reset)
		{
			rb.AddForce(-transform.forward * 75f, ForceMode.Impulse);
			_Reset = false;
		}
	}
}
