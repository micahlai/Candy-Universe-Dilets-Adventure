using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
    public bool switchToCredits = false;
	
	// Update is called once per frame
	void Update () {
		if (switchToCredits)
        {
            Application.LoadLevel("Credits");
        }
	}
}
