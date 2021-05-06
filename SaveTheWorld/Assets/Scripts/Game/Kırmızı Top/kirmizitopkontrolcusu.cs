using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirmizitopkontrolcusu : MonoBehaviour
{
    public GameObject patlama;

    oyunKontrol oyunKontrolScripti;

    void Start()
    {
        oyunKontrolScripti = GameObject.Find("_Scripts").GetComponent<oyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.5f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnMouseDown ()
    {
        GameObject go = Instantiate(patlama,transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.333f);
        oyunKontrolScripti.CanEksi();
    }
}
