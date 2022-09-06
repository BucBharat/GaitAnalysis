using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
}
