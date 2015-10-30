using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputNickname : MonoBehaviour {
	
	public InputField iField;
	public static string myName;

	// Use this for initialization
	void Start () {

	}

	public void OnMouseDown(){
		Debug.Log (iField.text);
		myName = iField.text;
	}

	// Update is called once per frame
	void Update () {

	}
}
