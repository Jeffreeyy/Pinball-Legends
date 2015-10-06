using UnityEngine;
using System.Collections;

public class FlipperController : MonoBehaviour {

	public GameObject leftFlipper;
	public GameObject rightFlipper;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		LeftFlipper ();
	}

	void LeftFlipper()
	{
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			//
		}
		
		if(Input.GetKeyUp(KeyCode.LeftArrow))
		{
			//
		}
	}
}
