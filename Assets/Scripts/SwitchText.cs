using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwitchText : MonoBehaviour
{
    public MasStringObject Names1;
    public MasStringObject Names2;
    public MasStringObject Names3;
    public ObjectP PP;
    public NumerTemi NT;

    private MasStringObject Names;

    void Start()
    {
        if (NT.NumerTem == 1) Names = Names1;
        else if (NT.NumerTem == 3) Names = Names3;
        if (NT.NumerTem == 3 || NT.NumerTem == 1)
            GetComponent<TextMeshProUGUI>().text = Names.Names[PP.Number].Split(' ')[0] + "\n" + Names.Names[PP.Number].Split(' ')[1] + "\n" + Names.Names[PP.Number].Split(' ')[2];
        else
        {
            string[] mass = Names2.Names[PP.Number].Split(' ');
            string str = mass[0] + " " + mass[1];
            string str1 = "";
            for (int i = 2; i < mass.Length; i++)
            {
                str1 += mass[i]+ " ";
            }
            GetComponent<TextMeshProUGUI>().text = str + "\n" + str1;
        }
    }
}
