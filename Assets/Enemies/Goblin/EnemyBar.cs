using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBar : MonoBehaviour
{
    public Transform target;
    public Transform bar;

    void Update()
    {
        transform.LookAt(target.transform);

    }
    public void EnemySize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }
}