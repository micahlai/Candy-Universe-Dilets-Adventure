using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicSwitch : MonoBehaviour {
    AudioSource Rock;
    AudioSource Poyo;
    AudioSource Ice;
    AudioSource Water;
    AudioSource Thunder;
    AudioSource Fire;
    AudioSource Nan;


    // Use this for initialization
    void Start()
    {
        Rock = GetComponent<AudioSource>();
        Poyo = GetComponent<AudioSource>();
        Ice = GetComponent<AudioSource>();
        Water = GetComponent<AudioSource>();
        Thunder = GetComponent<AudioSource>();
        Fire = GetComponent<AudioSource>();
        Nan = GetComponent<AudioSource>();
        Rock.clip = Resources.Load<AudioClip>("Rocky Plains");
        Poyo.clip = Resources.Load<AudioClip>("Poyo Forest");
        Ice.clip = Resources.Load<AudioClip>("Mt. Graupel");
        Water.clip = Resources.Load<AudioClip>("Hydria Lake");
        Thunder.clip = Resources.Load<AudioClip>("Coulombs Swamp");
        Fire.clip = Resources.Load<AudioClip>("Thermo Desert");
        Nan.clip = Resources.Load<AudioClip>("Mt. Blerbz");
    }
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Rock"))
        {
            Rock.Play();
        }
        if (collision.gameObject.CompareTag("Poyo"))
        {
            Poyo.Play();
        }
        if (collision.gameObject.CompareTag("Ice"))
        {
            Ice.Play();
        }
        if (collision.gameObject.CompareTag("Water"))
        {
            Water.Play();
        }
        if (collision.gameObject.CompareTag("Thunder"))
        {
            Thunder.Play();
        }
        if (collision.gameObject.CompareTag("Fire"))
        {
            Fire.Play();
        }
        if (collision.gameObject.CompareTag("Nan"))
        {
            Nan.Play();
        }
    }

}
