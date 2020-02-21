using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocky : MonoBehaviour {
    Rigidbody Rigid;
    void Start()
    {
        Rigid = GetComponent<Rigidbody>();
    }
    void ApplyDamage(int theDamage)
    {
        Rigid.AddForce(Vector3.up * 100);
        StartCoroutine(perish());
    }
    IEnumerator perish()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
