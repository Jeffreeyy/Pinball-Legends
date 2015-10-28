using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {

	public bool Left;
	public bool Right;

	public Vector3 l_com;
	public Vector3 r_com;

	private float _forceAmount = 10f;
	private Rigidbody rb;

	void Awake(){
		rb = GetComponent<Rigidbody> ();
		if(this.Left){
			rb.centerOfMass = l_com;
			
		}
		if(this.Right){
			rb.centerOfMass = r_com;
		}
	}

	void Update () {
		Flippers ();
	}

	private void Flippers(){
		if (this.Left)
		{
			if(Input.GetKey (KeyCode.LeftShift))
			{
				rb.AddForce(transform.forward * _forceAmount, ForceMode.Impulse);
			}
			else
			{
				rb.AddForce(-transform.forward * 2f, ForceMode.Impulse);
			}
		}


		if (this.Right)
		{
			if(Input.GetKey (KeyCode.RightShift))
			{
				rb.AddForce(transform.forward * _forceAmount, ForceMode.Impulse);
			}
			else
			{
				rb.AddForce(-transform.forward * 2f, ForceMode.Impulse);
			}
		}
	}
}
