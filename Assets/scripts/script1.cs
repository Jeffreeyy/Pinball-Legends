using UnityEngine;
using System.Collections;

public class script1 : MonoBehaviour {


	private int scoreOfzo = scoreCount.score;
	private string name = InputNickname.myName; 

	// Use this for initialization
	void Start () {

	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		if (www.error == null) {
		
			Debug.Log ("www ok!: " + www.text);
		} else {
		
			Debug.Log("www error: " + www.error);
		}

	}

	public void OnMouseDown()
	{
		if (name != null) {
			string url = "http://localhost/phpJaar2/phpToUnity.php";
		
			WWWForm form = new WWWForm ();
		
			form.AddField ("score", scoreOfzo);
		
			form.AddField ("name", name);
		
			WWW www = new WWW (url, form);
		
			StartCoroutine (WaitForRequest (www));
		}
	}

}