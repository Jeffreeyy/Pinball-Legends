using UnityEngine;
using System.Collections;

public class scoreCount : MonoBehaviour {
    public static int score = 0;
	public static bool AvariceBlade = false;
	private int BonusGold = 0;

	void Update(){
		if (AvariceBlade == true) {
			BonusGold = 20;
		}
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Buff")
        {
            score = score + 60 + BonusGold;
        }

		if (col.gameObject.tag == "Turret")
		{
			score = score + 125 + BonusGold;
		}
    }
}
