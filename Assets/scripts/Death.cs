using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
	
	private Vector3 _spawnPoint;
    public int Lifes = 3;

	void Awake()
	{
		_spawnPoint = new Vector3 (24.05f, 0.25f, 0.7f);
	}

    void Update() 
    {
        if (Lifes == 0) 
        {
            Application.LoadLevel("GameOver");
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball" && Lifes != 0)
        {
			col.gameObject.transform.position = _spawnPoint;
            Lifes--;
        }
    }
    
}

