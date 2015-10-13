using UnityEngine;
using System.Collections;

public class BuyItems : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if (scoreCount.score >= 1200) {
			scoreCount.score = scoreCount.score - 1200;
			scoreCount.AvariceBlade = true;
		}
	}
}
