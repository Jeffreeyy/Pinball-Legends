using UnityEngine;
using System.Collections;

public class SpringBackup : MonoBehaviour {

	private Rigidbody rb;
	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();
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
		}
		if(Input.GetKeyUp (KeyCode.Space))
		{
			ResetSpring();
		}
	}

	private void UseSpring()
	{
		rb.constraints &= ~RigidbodyConstraints.FreezePositionZ;
		Debug.Log ("schiet");
		rb.AddForce (transform.forward * 50f, ForceMode.Impulse);
	}

	private void ResetSpring()
	{
		rb.constraints |= RigidbodyConstraints.FreezePositionZ;
		this.transform.position = new Vector3 (24.029f, 0.25f, -4.739f);
	}
}
