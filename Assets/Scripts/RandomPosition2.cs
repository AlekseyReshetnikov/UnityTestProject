using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomPosition2 : MonoBehaviour
{
    private System.Random rnd;
    private int[] masNum;

    public ObjectP[] PP;
    public RoundsKolvo RAOT;
    private int KolvoElement = 9;
    public int KolvoMest = 7;
    public NumerTemi NT;

    void OnEnable()
    {
        if (NT.NumerTem == 3) KolvoElement = 10;
        masNum = new int[KolvoElement];
        for (int i = 0; i < KolvoElement; i++)
        {
            masNum[i] = i;
        }
        //print(masNum);
    }

    public void RPKE()
    {
        rnd = new System.Random();
        PP[0].Kto = rnd.Next(0, KolvoMest);
        for (int i = 1; i < PP.Length; i++)
        {
            PP[i].Kto = Rund(i);
        }
        int c = rnd.Next(4, 10);
        for (int i = 0; i < c; i++)
        {
            int c1 = rnd.Next(0, KolvoElement);
            int c2 = rnd.Next(0, KolvoElement);
            //print(c1);
            //print(c2);
            //print(masNum);
            (masNum[c1], masNum[c2]) = (masNum[c2], masNum[c1]);
        }
        for (int i = 0; i < PP.Length; i++)
        {
            PP[i].Number = masNum[i];
        }
        //RAOT.NumerRound = 0;
    }
    
    private int Rund(int num)
    {
        int r = rnd.Next(0, KolvoMest);
        bool Ff = false;
        
        for (int i = 0; i < num; i++)
        {
            if (r == PP[i].Kto)
            {
                Ff = true;
                break;                    
            }
        }

        if (Ff)
        {
            return Rund(num);
        }
        else
        {
            return r;
        }
    }
}
