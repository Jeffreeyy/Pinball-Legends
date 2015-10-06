using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {

	public bool Left;
	public bool Right;
	// Use this for initialization
	void Start () {
		//
	}
	
	// Update is called once per frame
	void Update () {
		Flippers ();
	}

	private void Flippers(){
		if (Input.GetKeyDown (KeyCode.A) && this.Left)
		{
			Debug.Log("hallo");
			this.GetComponent<Rigidbody>().AddForce(transform.forward * 100, ForceMode.Impulse);
		}
		if(Input.GetKeyUp (KeyCode.A) && this.Left)
		{
			this.GetComponent<Rigidbody>().AddForce((transform.forward * 10)*-1, ForceMode.Impulse);
		}
	}
}
