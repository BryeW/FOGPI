using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject prefab;

    void Update()
    {
        SuperPupSystems.Helper.SimpleObjectPool.instance.SpawnFromPool("coin", transform.position, transform.rotation);
    }
}
