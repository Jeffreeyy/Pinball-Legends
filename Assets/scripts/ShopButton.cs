using UnityEngine;
using System.Collections;

public class ShopButton : MonoBehaviour {

	public GameObject panel;
	// Use this for initialization
	void Start () {
		OpenShop (panel);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OpenShop(GameObject panel){
		panel.SetActive (!panel.activeSelf);
	}
}
