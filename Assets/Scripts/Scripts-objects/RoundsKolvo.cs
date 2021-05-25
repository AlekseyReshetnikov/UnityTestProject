using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class RoundsKolvo : ScriptableObject
{
    public int NumerRound;
    public bool ObuchText;
    public int KolvoErrors;

    public void ErrorsPlus()
    {
        KolvoErrors += 1;
    }

    public void ErrorsNull()
    {
        KolvoErrors = 0;
        NumerRound = 0;
    }
}
