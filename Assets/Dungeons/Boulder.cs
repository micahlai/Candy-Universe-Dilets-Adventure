using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour {
    public Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("BoulderEnd"))
        {
            transform.position = startPos;
        }
    }
}
