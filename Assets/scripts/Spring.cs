using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour {
	
	private Rigidbody rb;
	private bool _isFrozen = true;
	private Vector3 _startPos;
	private bool _isInPlace = true;
	public AudioSource kickSound;
	
	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();
		kickSound = GetComponent<AudioSource> ();
		_startPos = transform.position;
	}
	
	void Start()
	{
		FreezeStatus ();
	}
	
	// Update is called once per frame
	void Update () {
		PullSpring ();
		if (!_isInPlace) 
		{
			if(transform.position.z >= _startPos.z)
			{
				rb.velocity = new Vector3(0, 0, 0);
				_isInPlace = true;
				_isFrozen = true;
				FreezeStatus ();
				transform.position = _startPos;
			}
		}
		
	}
	
	private void PullSpring()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			_isFrozen = false;
			FreezeStatus ();		
		} 
		
		else if (Input.GetKeyUp (KeyCode.Space)) {
			kickSound.Play ();
			_isFrozen = false;
			rb.AddForce (transform.forward * 50f, ForceMode.Impulse);
			_isInPlace = false;
			FreezeStatus();
		}
		
	}
	
	private void FreezeStatus()
	{
		if(_isFrozen)
		{
			rb.constraints |= RigidbodyConstraints.FreezePositionZ;
		}
		if(!_isFrozen)
		{
			rb.constraints &= ~RigidbodyConstraints.FreezePositionZ;
		}
	}
}
