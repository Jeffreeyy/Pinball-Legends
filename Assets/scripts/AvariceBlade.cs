using UnityEngine;
using System.Collections;

public class AvariceBlade : MonoBehaviour {

	public Material avariceBladeUnavailable;
	public Renderer rend;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		if (scoreCount.score >= 1200 && scoreCount.AvariceBlade == false) {
			rend.material = avariceBladeUnavailable;
			scoreCount.score = scoreCount.score - 1200;
			scoreCount.AvariceBlade = true;
		}
	}
}
