using UnityEngine;
using System.Collections;

public class LoadGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution (1600, 729, true);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnMouseDown(){
		Application.LoadLevel ("Bronzo");
	}
}