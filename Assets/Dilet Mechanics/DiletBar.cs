using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiletBar : MonoBehaviour {
    private Transform bar;
	// Use this for initialization
	void Start () {
        bar = transform.Find("Bar");
	}
	
	// Update is called once per frame
	public void SetSize(float sizeNormalized) {
        bar.localScale = new Vector3(sizeNormalized, 1f);
	}
    public void SetColor(Color color)
    {
        bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = color;
    }
}
