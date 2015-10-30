using UnityEngine;
using System.Collections;

public class LoadHighScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnMouseDown(){
		Application.LoadLevel ("HighScore");
	}
}
