using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedmavikontrol : MonoBehaviour
{
    public GameObject patlama;

    speedKontrol speedKontrolScripti;
    void Start()
    {
        speedKontrolScripti = GameObject.Find("_Scripts").GetComponent<speedKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.5f)
        {
            Destroy(this.gameObject);
            speedKontrolScripti.CanEksi();
        }
    }

    void OnMouseDown ()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation);
        Destroy(this.gameObject);
        Destroy(go, 0.333f);
        speedKontrolScripti.BalonEkle();
    }
}
