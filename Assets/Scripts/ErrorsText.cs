using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ErrorsText : MonoBehaviour
{
    private string text = "Oшибок:\n";
    //public int errors = 0;
    public RoundsKolvo RAOT;

    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = text + RAOT.KolvoErrors;
    }

    public void AddError()
    {
        RAOT.KolvoErrors += 1;
        GetComponent<TextMeshProUGUI>().text = text + RAOT.KolvoErrors;
    }
}
