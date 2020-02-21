using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal : MonoBehaviour {
    public GameObject activateButton;
    public TerminalControl terminal;
    private bool activated;
    
    void Start()
    {
        activateButton.GetComponent<Renderer>().material.color = new Color(1.0f, 0f, 0.0f);
    }
    void ApplyDamage(int theDamage)
    {
        if (!activated)
        {
            StartCoroutine(Fade(1, 0));
            terminal.terminals -= 1;
            activated = true;
        }
    }
    IEnumerator Fade(float Sec, float a)
    {

        for (float i = 1; i >= 0; i -= Time.deltaTime / Sec)
        {
            a = (i * -1) + 1;
            activateButton.GetComponent<Renderer>().material.color = new Color(i, a, a);
            yield return null;
        }
    }
}
