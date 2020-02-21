using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnSlap : MonoBehaviour {
    void ApplyDamage(int theDamage)
    {
        Destroy(gameObject);
    }
}
