using UnityEngine;
using System.Collections;

public class ShopButton : MonoBehaviour {

	public GameObject panel;
	private bool isShopOpen = false;
	// Use this for initialization
	void Start () {
		OpenShop (panel);
	}
	
	// Update is called once per frame
	void Update () {
		if (panel) {
			Time.timeScale = 0;
			isShopOpen = true;
		}
	}

	public void OpenShop(GameObject panel){
		panel.SetActive (!panel.activeSelf);
		if (isShopOpen == true) {
			Time.timeScale = 1;
		}
	}
}
