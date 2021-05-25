using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TrFaErEdro : MonoBehaviour
{
    public ObjectP PP;
    public GameObject Otext;
    public GameObject Okn;
    public Transform[] TransformingO;
    public Transform[] TransformingT;
    public bool N1Glav = false;
    public MasStringObject Names1;
    public MasStringObject Names2;
    public MasStringObject Names3;
    public RoundsKolvo RAOT;
    public GameObject end;
    public GameObject Endend;
    public GameObject LCh;
    public NumerTemi NT;

    private System.Random rnd;
    private MasStringObject Names;

    void Start()
    {
        if (NT.NumerTem == 1) Names = Names1;
        else if (NT.NumerTem == 3) Names = Names3;
        this.transform.position = TransformingO[PP.Kto].position;
        Okn.transform.position = TransformingT[PP.Kto].position;
        rnd = new System.Random(PP.Number);
        if (N1Glav)
        {
            if (NT.NumerTem == 3 || NT.NumerTem == 1)
                Otext.GetComponent<TextMeshProUGUI>().text = Names.Names[PP.Number].Split(' ')[0] + "\n" + Names.Names[PP.Number].Split(' ')[1] + "\n" + Names.Names[PP.Number].Split(' ')[2];
            else
            {
                string[] mass = Names2.Names[PP.Number].Split(' ');
                string str = mass[0] + " " + mass[1];
                string str1 = "";
                for (int i = 2; i < mass.Length; i++)
                {
                    str1 += mass[i] + " ";
                }
                Otext.GetComponent<TextMeshProUGUI>().text = str + "\n" + str1;
            }
        }
        else
        {
            int r = rnd.Next(1, 8);
            while (r == PP.Number) r = rnd.Next(1, 8);
            if (NT.NumerTem == 3 || NT.NumerTem == 1)
                Otext.GetComponent<TextMeshProUGUI>().text = Names.Names[r].Split(' ')[0] + "\n" + Names.Names[r].Split(' ')[1] + "\n" + Names.Names[r].Split(' ')[2];
            else
            {
                string[] mass = Names2.Names[r].Split(' ');
                string str = mass[0] + " " + mass[1];
                string str1 = "";
                for (int i = 2; i < mass.Length; i++)
                {
                    str1 += mass[i] + " ";
                }
                Otext.GetComponent<TextMeshProUGUI>().text = str + "\n" + str1;
            }
        }
    }

    public void LevelEnd()
    {
        if (RAOT.NumerRound < 5)
        {
            RAOT.NumerRound += 1;
            end.SetActive(true);
            StartCoroutine(Cortina());
        } else
        {
            RAOT.NumerRound = 0;
            Endend.SetActive(true);
        }
    }

    private IEnumerator Cortina()
    {
        yield return new WaitForSeconds(1f);
        GetComponent<RandomPosition2>().RPKE();
        LCh.GetComponent<LevelChanger>().FadeToLevel(2);
    }
}
