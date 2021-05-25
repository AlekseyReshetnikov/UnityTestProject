using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteUnLock : MonoBehaviour
{
    private Animator anim;

    public string index;

    void Start()
    {
        anim = GetComponent<Animator>();
        if (PlayerPrefs.GetInt(("UnPublic" + index)) == 1)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetTrigger("Tg");
        PlayerPrefs.SetInt(("UnPublic" + index), 1);
        PlayerPrefs.Save();
    }
}
