using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    
    void Explode()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();        
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball")
        {
            Explode();
            Destroy(col.gameObject);
            transform.GetComponent<Renderer>().material.color = Color.grey;
        }
    }
    
}

