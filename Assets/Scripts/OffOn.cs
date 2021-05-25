using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffOn : MonoBehaviour
{
    public GameObject BN;
    public GameObject BN2;

    public void OFF()
    {
        BN.SetActive(false);
    }

    public void ON()
    {
        BN2.SetActive(true);
    }
}
