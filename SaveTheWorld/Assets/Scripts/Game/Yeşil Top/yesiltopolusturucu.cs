using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yesiltopolusturucu : MonoBehaviour
{
    public GameObject yesiltop;
    public float zaman = 20f;

    public int sayi = 10;
    oyunKontrol okScripti;
    void Start()
    {
        okScripti = this.gameObject.GetComponent<oyunKontrol>();   
    }

    // Update is called once per frame
    void Update()
    {
        zaman -= Time.deltaTime;
        int katsayi = (int)(okScripti.patlayanBalon / sayi);
        katsayi *= -1;
        if (okScripti.canSayaci > 0 && zaman < 0)
        {
            GameObject go = Instantiate(yesiltop, new Vector3(Random.Range(-8f, 8f), 6, 0), Quaternion.Euler(0,0,0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(60f * katsayi, 100f * katsayi), 0));
            zaman = 15f;
        }
        if (okScripti.patlayanBalon >= 50)
        {
            sayi = 5;
        }
    }
}
