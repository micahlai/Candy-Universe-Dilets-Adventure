using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI : MonoBehaviour
{
    public Transform target;
    public int BossHealth = 100;
    public EnemyBar Bar;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);

    }
    void ApplyDamage(int TheDamage)
    {
        BossHealth -= TheDamage;
    }
}
