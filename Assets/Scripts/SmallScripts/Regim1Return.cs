using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regim1Return : MonoBehaviour
{
    private int Ansvers = 6;

    public GameObject LC;
    public RoundsKolvo RAOT;
    public GameObject EndPanel;

    public void RightAnsver()
    {
        Ansvers -= 1;
        if (Ansvers == 0 && RAOT.NumerRound != 2)
        {
            RAOT.NumerRound += 1;
            this.GetComponent<RandomPosition2>().RPKE();
            LC.GetComponent<LevelChanger>().FadeToLevel(1);
        } else if (Ansvers == 0 && RAOT.NumerRound == 2)
        {
            EndPanel.SetActive(true);
        }
    }
}
