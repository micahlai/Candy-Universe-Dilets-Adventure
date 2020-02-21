using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {
    public bool loadMenu = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Cancel"))
        {
            Application.LoadLevel(0);
        }
        if (loadMenu)
        {
            Application.LoadLevel(0);
        }

    }
}
