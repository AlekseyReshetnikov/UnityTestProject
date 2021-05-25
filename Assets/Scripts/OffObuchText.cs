using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffObuchText : MonoBehaviour
{
    public RoundsKolvo RAOT;
    public GameObject BN;

    void Start()
    {
        if (PlayerPrefs.GetInt("ObuchText") != 1 || RAOT.NumerRound != 0)
        {
            BN.SetActive(false);
        }
    }

    public void Off()
    {
        BN.SetActive(false);
    }
}
