using UnityEngine;
using System.Collections;

public class scoreCount : MonoBehaviour {
    public static int score = 0;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ball")
        {
            score = score + 10;
            Debug.Log(score);
        }
    }
}
