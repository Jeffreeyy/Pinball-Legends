using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ball")
        {
            Debug.Log("coliders");
            Destroy(col.gameObject);
        }
    }
    
}

