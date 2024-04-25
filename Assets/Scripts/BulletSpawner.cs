using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletSpawner : MonoBehaviour
{
    public GameObject prefab;

    void Update()
    {
        SuperPupSystems.Helper.SimpleObjectPool.instance.SpawnFromPool("bullet", transform.position, transform.rotation);
    }
}
