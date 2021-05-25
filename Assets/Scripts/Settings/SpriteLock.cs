using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLock : MonoBehaviour
{
    public string[] index;


    public void Lock()
    {
        for (int i = 0; i < index.Length; i++)
        {
            PlayerPrefs.SetInt(("UnPublic" + index[i]), 0);
            PlayerPrefs.Save();
        }
    }
}
