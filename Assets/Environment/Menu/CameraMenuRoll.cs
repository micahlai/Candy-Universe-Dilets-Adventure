using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class CameraMenuRoll : MonoBehaviour {
    public Camera cameraObject1;
    public Camera cameraObject2;
    public Camera cameraObject3;
    public Camera cameraObject4;
    void Start () {
        cameraObject1.gameObject.SetActive(true);
        cameraObject2.gameObject.SetActive(false);
        cameraObject3.gameObject.SetActive(false);
        cameraObject4.gameObject.SetActive(false);
    }
	
	void Update () {
        cameraObject1.gameObject.SetActive(true);
        cameraObject2.gameObject.SetActive(false);
        System.Threading.Thread.Sleep(10000);
        cameraObject2.gameObject.SetActive(true);
        cameraObject3.gameObject.SetActive(false);
        System.Threading.Thread.Sleep(10000);
        cameraObject3.gameObject.SetActive(true);
        cameraObject4.gameObject.SetActive(false);
        System.Threading.Thread.Sleep(10000);
        cameraObject4.gameObject.SetActive(true);
        cameraObject1.gameObject.SetActive(false);
        System.Threading.Thread.Sleep(10000);
    }
}
