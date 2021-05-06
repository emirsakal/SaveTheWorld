using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedkirmizi : MonoBehaviour
{
    public GameObject kirmizitop;
    public float zaman = 5f;
    speedKontrol skScripti;
    void Start()
    {
     skScripti = this.gameObject.GetComponent<speedKontrol>();   
    }

    // Update is called once per frame
    void Update()
    {
        zaman -= Time.deltaTime;
        int katsayi = (int)(skScripti.patlayanBalon / 5);
        katsayi *= -1;
        if (skScripti.canSayaci > 0 && zaman < 0)
        {
            GameObject go = Instantiate(kirmizitop, new Vector3(Random.Range(-2.4f, 2.4f), 6, 0), Quaternion.Euler(0,0,0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(60f * katsayi, 100f * katsayi), 0));
            zaman = 5f;
        }
    }
}
