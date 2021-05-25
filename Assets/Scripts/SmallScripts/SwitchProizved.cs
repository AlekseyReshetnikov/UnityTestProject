using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchProizved : MonoBehaviour
{
    public NumerTemi NT;
    public MasStringObject MSO;

    private System.Random rnd;

    public void SwitchText()
    {
        rnd = new System.Random();
        MSO.Names[0] = NT.Proizved1[rnd.Next(0, NT.Proizved1.Length)];
        MSO.Names[1] = NT.Proizved2[rnd.Next(0, NT.Proizved2.Length)];
        MSO.Names[2] = NT.Proizved3[rnd.Next(0, NT.Proizved3.Length)];
        MSO.Names[3] = NT.Proizved4[rnd.Next(0, NT.Proizved4.Length)];
        MSO.Names[4] = NT.Proizved5[rnd.Next(0, NT.Proizved5.Length)];
        MSO.Names[5] = NT.Proizved6[rnd.Next(0, NT.Proizved6.Length)];
        MSO.Names[6] = NT.Proizved7[rnd.Next(0, NT.Proizved7.Length)];
        MSO.Names[7] = NT.Proizved8[rnd.Next(0, NT.Proizved8.Length)];
        MSO.Names[8] = NT.Proizved9[rnd.Next(0, NT.Proizved9.Length)];
    }
}
