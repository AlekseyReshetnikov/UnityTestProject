using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomPosition1 : MonoBehaviour
{
    public ObjectP objectss;
    public MasSprites Mass1;
    public MasSprites Mass3;
    public NumerTemi NT;

    private System.Random rnd;
    private MasSprites Mass;

    void Start()
    {
        if (NT.NumerTem == 1) Mass = Mass1;
        else if (NT.NumerTem == 2) Mass = Mass1;
        else if (NT.NumerTem == 3) Mass = Mass3;
        rnd = new System.Random();
        int R = (rnd.Next(0, 3) + objectss.Number - objectss.Kto * 2) % 3;
        if (R == 0)
        {
            GetComponent<SpriteRenderer>().sprite = Mass.mass1[objectss.Number];
        }else if (R == 1)
        {
            GetComponent<SpriteRenderer>().sprite = Mass.mass2[objectss.Number];
        } else
        {
            GetComponent<SpriteRenderer>().sprite = Mass.mass3[objectss.Number];
        }
    }
}
