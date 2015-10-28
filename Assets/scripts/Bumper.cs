using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

	private float _force = 1000f;
	private float _forceRadius = 0.5f;

	void OnCollisionEnter()
	{
		foreach(Collider col in Physics.OverlapSphere(transform.position, _forceRadius))
		{
			if(col.attachedRigidbody)
			{
				col.attachedRigidbody.AddExplosionForce(_force, transform.position, _forceRadius);
			}
		}
	}
}
