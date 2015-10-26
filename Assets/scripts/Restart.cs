using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(0); //or whatever number your scene is
            scoreCount.score = 0;
        }
    }
}
