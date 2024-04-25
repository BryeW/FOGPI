using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiggyBank : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            WalletManager.instance.AddCoin(1);
            Destroy(other.gameObject);
        }
    }
}
