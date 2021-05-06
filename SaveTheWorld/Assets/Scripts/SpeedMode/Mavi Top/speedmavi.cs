using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedmavi : MonoBehaviour
{
    public GameObject mavitop;
    public float zaman = 1f;

    public int sayi = 5;
    speedKontrol skScripti;
    void Start()
    {
     skScripti = this.gameObject.GetComponent<speedKontrol>();   
    }

    // Update is called once per frame
    void Update()
    {
        zaman -= Time.deltaTime;
        int katsayi = (int)(skScripti.patlayanBalon / sayi);
        katsayi *= -1;
        if (skScripti.canSayaci > 0 && zaman < 0)
        {
            GameObject go = Instantiate(mavitop, new Vector3(Random.Range(-8f, 8f), 6, 0), Quaternion.Euler(0,0,0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(60f * katsayi, 100f * katsayi), 0));
            zaman = 1f;
        }
    }
}
