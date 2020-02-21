using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxAttack1 : MonoBehaviour {
    public GameObject hitbox;
    public Animator Anim;

    void Start () {
        hitbox.transform.gameObject.SetActive(false);
        Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Anim.GetCurrentAnimatorStateInfo(0).IsName("Zombie Kicking"))
        {
            hitbox.transform.gameObject.SetActive(true);
        }
        else
        {
            hitbox.transform.gameObject.SetActive(false);
        }
    

    }
}
