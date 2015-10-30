using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class script2 : MonoBehaviour {
	
	
	public int scoreOfzo = 1;
	//public string[] stringArray;
	public Text fileText;
    /*public Text fileText2;
    public Text fileText3;
    public Text fileText4;
    public Text fileText5;
    public Text fileText6;*/

    // Use this for initialization
    void Start () {
		
		string url = "http://localhost/phpJaar2/phpToUnity2.php";
		
		WWW www = new WWW (url);
		
		StartCoroutine (WaitForRequest (www));


		}

	
	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
		
		if (www.error == null)
        {
  
  
            ReadIncomingData(www.text);

			Debug.Log ("www ok!: " + www.text);

		} else {
			
			Debug.Log("www error: " + www.error);
		}
		
	}


    public void ReadIncomingData(string incomingString)
    {
        string[] splitData = incomingString.Trim().Split('\n');

        if (incomingString == string.Empty)return;


        int count = 0;
        foreach (string entry in splitData)
        {
            if (!entry.Contains("\t"))
            {
                string[] temp = entry.Split('\t');
                
            }
            fileText.text = splitData[count];
            count++;
            /*fileText2.text = splitData[count];
            count++;
            fileText3.text = splitData[count];
            count++;
            fileText4.text = splitData[count];
            count++;
            fileText5.text = splitData[count];
            count++;
            fileText6.text = splitData[count];*/

        }
    }
}