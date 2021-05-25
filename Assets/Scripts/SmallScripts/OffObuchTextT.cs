using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffObuchTextT : MonoBehaviour
{
    public RoundsKolvo RAOT;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        if (PlayerPrefs.GetInt("ObuchText") != 1) anim.SetTrigger("Tg");
    }

    public void OnOff()
    {
        RAOT.ObuchText = !RAOT.ObuchText;
        if (PlayerPrefs.GetInt("ObuchText") == 1)
            PlayerPrefs.SetInt("ObuchText", 0);
        else PlayerPrefs.SetInt("ObuchText", 1);
        anim.SetTrigger("Tg");
    }
}
