using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {
    public ParticleSystem exp;
    // Use this for initialization
    void Start () {
        exp = GetComponent<ParticleSystem>();
        exp.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
