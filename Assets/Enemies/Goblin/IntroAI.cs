using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAI : MonoBehaviour {
    public GameObject target;
    public int Health = 100;
    public bool playCutscene = false;
    public EnemyBar Bar;
    private float barSize;
    public ParticleSystem explode;
    static Animator Anim;
    public float distanceUntilNotice;
    
    void Start()
    {
        Anim = GetComponent<Animator>();
    }
    void Update()
    {

        if ((target.transform.position - this.transform.position).sqrMagnitude < distanceUntilNotice)
        {
            transform.LookAt(target.transform);
            Anim.SetTrigger("Attack");
        }

        if (Anim.GetCurrentAnimatorStateInfo(0).IsName("Zombie Death"))
        {
            explode.Play();
            Destroy(gameObject);
            if (playCutscene)
            {
                Application.LoadLevel("Cutscene2");
            }
            else
            {
                Application.LoadLevel("Overworld 3");
            }
            
        }
        barSize = Health;
        barSize = barSize / 100;
        Bar.EnemySize(barSize);
        if (Input.GetButtonDown("Cancel"))
        {
            if (playCutscene)
            {
                Application.LoadLevel("Cutscene2");
            }
            else
            {
                Application.LoadLevel("Overworld 3");
            }
        }

    }
    void ApplyDamage(int TheDamage)
    {
        Health -= TheDamage;
        if (Health <= 0)
        {
            Anim.SetTrigger("Death");
            
            

        }

    }
}

