using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour {
    public Transform cameraOrbit;
    public float speed = 1f;
    public float deg;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cameraOrbit.transform.Rotate(0, deg, 0);
        deg += speed / 100;
    }
}
