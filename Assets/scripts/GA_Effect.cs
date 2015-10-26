using UnityEngine;
using System.Collections;

public class GA_Effect : MonoBehaviour {

	[SerializeField]private Transform spawnPoint;
	[SerializeField]private GameObject GuardianAngel;
	public static bool GuardianAngelEffect;
	public static bool remove = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GuardianAngelEffect) {
			Instantiate(GuardianAngel, spawnPoint.position, spawnPoint.rotation);
			GuardianAngelEffect = false;
		}
		if (remove) {
			Destroy(GuardianAngel);
		}
	}
}
