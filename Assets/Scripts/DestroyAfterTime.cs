using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    private float lifeTime = 2f;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
