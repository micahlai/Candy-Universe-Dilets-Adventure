using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnSlap : MonoBehaviour {
    public GameObject door;
    public GameObject activateObject;
    private bool activated = false;
    // Use this for initialization
    private void Start()
    {
        activateObject.GetComponent<Renderer>().material.color = new Color(1.0f, 0f, 0.0f);
    }
    void ApplyDamage(int theDamage)
    {
        if (!activated)
        {
            Destroy(door);
            StartCoroutine(Fade(1, 0));
            activated = true;
        }
     }

    IEnumerator Fade(float Sec, float a)
    {

        for (float i = 1; i >= 0; i -= Time.deltaTime / Sec)
        {
            a = (i * -1) + 1;
            activateObject.GetComponent<Renderer>().material.color = new Color(i, a, a);
            yield return null;
        }
    }
}
