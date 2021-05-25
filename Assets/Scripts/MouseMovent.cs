using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovent : MonoBehaviour
{
    bool MouseDown = false;

    public Transform CenterPoint;
    public float MaxDistance = 4;
    public GameObject Galka;
    public GameObject Crestic;
    public GameObject ramka;
    public GameObject TexT;
    public GameObject TextError;

    public int NachalRandom = 1;
    public Transform[] Transforming;
    public ObjectP objectss;
    public GameObject RightAnsver;

    Vector3 StartPosition;
    Animator animG;
    Animator animC;

    public string index = "Ramka";

    void Start()
    {
        //System.Random rnd = new System.Random(NachalRandom);
        //int Namber = rnd.Next(Transforming.Length);
        this.transform.position = Transforming[objectss.Kto].position;
        animC = Crestic.GetComponent<Animator>();
        animG = Galka.GetComponent<Animator>();
        StartPosition = GetComponent<Transform>().position;
    }

    void OnMouseDown()
    {
        MouseDown = true;
    }

    void OnMouseUp()
    {
        MouseDown = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject != ramka && other.gameObject.tag == index && this.transform.position != StartPosition)
        {
            animC.SetTrigger("Tr");
            TextError.GetComponent<ErrorsText>().AddError();
        }

        if (other.gameObject == ramka && this.transform.position != StartPosition)
        {
            animG.SetTrigger("Tr");
            GetComponent<Transform>().position = ramka.transform.position;
            StartPosition = ramka.GetComponent<Transform>().position;
            ramka.SetActive(false);
            TexT.SetActive(false);
            MouseDown = false;
            GetComponent<SpriteRenderer>().sortingOrder = 0;
            this.GetComponent<BoxCollider2D>().enabled = false;
            RightAnsver.GetComponent<Regim1Return>().RightAnsver();
            this.GetComponent<MouseMovent>().enabled = false;
        }
    }

    private void Update()
    {
        Vector2 Cursor = Input.mousePosition;
        Cursor = Camera.main.ScreenToWorldPoint(Cursor);

        float dist = Vector2.Distance(CenterPoint.position, this.transform.position);

        if (MouseDown)
        {
            GetComponent<SpriteRenderer>().sortingOrder = 2;
            if (MaxDistance > dist)
                this.transform.position = Cursor;
        }
        else
        {
            this.transform.position = StartPosition;
            GetComponent<SpriteRenderer>().sortingOrder = 1;
        }
    }
}
