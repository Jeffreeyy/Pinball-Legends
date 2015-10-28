using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
	
	private Vector3 _spawnPoint;

	void Awake()
	{
		_spawnPoint = new Vector3 (24.05f, 0.25f, 0.7f);
	}

    void Explode()
    {
        //var exp = GetComponent<ParticleSystem>();
        //exp.Play();        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball")
        {
            //Explode();
			col.gameObject.transform.position = _spawnPoint;
            //transform.GetComponent<Renderer>().material.color = Color.grey;
        }
    }
    
}

