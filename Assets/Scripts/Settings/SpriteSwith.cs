using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwith : MonoBehaviour
{
    public Sprite[] NewSprite;
    public GameObject BN;
    public int index;
    public string[] Unnpublik = { "None"};

    private int NamberSprite;

    void Start()
    {
        BN.GetComponent<SpriteRenderer>().sprite = NewSprite[PlayerPrefs.GetInt(("SpriteSwitch" + index))];
        NamberSprite = PlayerPrefs.GetInt(("SpriteSwitch" + index));
    }

    public void SpritesSwith()
    {
        BN.GetComponent<SpriteRenderer>().sprite = NewSprite[NamberSprite];
        PlayerPrefs.SetInt(("SpriteSwitch" + index), NamberSprite);
        PlayerPrefs.Save();
    }

    public void SpritePlus()
    {
        if (NamberSprite + 1 >= NewSprite.Length)
        {
            NamberSprite = -1;
        }
        if (Unnpublik[NamberSprite + 1] == "None" || PlayerPrefs.GetInt(("UnPublic" + Unnpublik[NamberSprite + 1])) == 1)
        {
            NamberSprite += 1;
            SpritesSwith();
        }
        else
        {
            NamberSprite += 1;
            SpritePlus();
        }
    }

    public void SpriteMinus()
    {
        if (NamberSprite - 1 <= -1)
        {
            NamberSprite = NewSprite.Length;
        }
        if (Unnpublik[NamberSprite - 1] == "None" || PlayerPrefs.GetInt(("UnPublic" + Unnpublik[NamberSprite - 1])) == 1)
        {
            NamberSprite -= 1;
            SpritesSwith();
        }
        else
        {
            NamberSprite -= 1;
            SpriteMinus();
        }
    }
}
