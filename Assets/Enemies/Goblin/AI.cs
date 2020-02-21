using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
    public Transform target;
    public int Health = 100;
    public EnemyBar Bar;
    private float barSize;
    public ParticleSystem explode;

    static Animator Anim;
    public float distanceUntilNotice = 30f;
    
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
        }
        barSize = Health;
        barSize = barSize / 100;
        Bar.EnemySize(barSize);

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

