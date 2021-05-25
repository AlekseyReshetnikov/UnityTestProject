using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KN1A : MonoBehaviour
{
    private Animator anim;
    private Animator animBN;
    public GameObject BN;

    private void Start()
    {
        anim = GetComponent<Animator>();
        animBN = BN.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetBool("KN1On", true);
        animBN.SetBool("BN", true);
    }
}
