using UnityEngine;
using System.Collections;

public class scoreCount : MonoBehaviour {
    public static int score = 0;
	public static bool AvariceBlade = false;
	public static bool GuardianAngel = false;
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

        if (col.gameObject.tag == "EnemyNexus")
        {
			score = score + 250 + BonusGold;
        }
        if (col.gameObject.tag == "Inhib")
        {
			score = score + 175 + BonusGold;
        }
		if (col.gameObject.tag == "Drake") 
		{
			score = score + 190 + BonusGold;
		}
        if (col.gameObject.tag == "Baron")
        {
            score = score + 200 + BonusGold;
        }
    }
}