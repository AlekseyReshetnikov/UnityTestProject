using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTem : MonoBehaviour
{
    public NumerTemi NT;

    public void Swith(int Numer)
    {
        NT.NumerTem = Numer;
    }
}
