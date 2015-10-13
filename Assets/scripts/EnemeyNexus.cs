using UnityEngine;
using System.Collections;

public class EnemeyNexus : MonoBehaviour {

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
            transform.GetComponent<Renderer>().material.color = Color.grey;
        }
    }

}
