using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalletManager : MonoBehaviour
{
    public static WalletManager instance;

    public int coin = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("More that one WalletManager found in the scene");
            Destroy(gameObject);
        }
    }

    public void AddCoin(int _amount)
    {
        coin += _amount;
    }
}
