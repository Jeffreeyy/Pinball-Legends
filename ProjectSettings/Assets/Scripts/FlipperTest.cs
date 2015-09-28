using UnityEngine;
using System.Collections;

public class FlipperTest : MonoBehaviour {

	public Transform rightFlipper;
	public Transform leftFlipper;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			leftFlipper.rotation = Quaternion.Euler(20,0,0);
		}
	}
}
