using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunKontrol : MonoBehaviour
{
    public Text balonText;
    public int patlayanBalon = 0;
    public int canSayaci = 1;
    public GameObject patlamacık;
    public UnityEngine.UI.Button btn;
    public UnityEngine.UI.Button btn1;
    public UnityEngine.UI.Button btn2;

    public UnityEngine.UI.Image image1, image2, image3;

    void Start()
    {
        balonText.text = patlayanBalon + "";
    }

    void Update()
    {
        if (canSayaci <= 0)
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("top");
            for(int i = 0; i < go.Length; i++)
            {
                GameObject go1 = Instantiate(patlamacık, go[i].transform.position, go[i].transform.rotation);
                Destroy(go [i]);
                Destroy(go1, 3f);
            }
            btn.gameObject.SetActive(true);
            btn1.gameObject.SetActive(true);
            btn2.gameObject.SetActive(true);
        }


    }
    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonText.text = patlayanBalon + "";
    }
    public void CanEksi ()
    {
        canSayaci -= 1;
        if (canSayaci == 0)
        {
            image1.gameObject.SetActive(false);
            image2.gameObject.SetActive(false);
            image3.gameObject.SetActive(false);
        }
        else if (canSayaci == 1)
        {
            image1.gameObject.SetActive(true);
            image2.gameObject.SetActive(false);
            image3.gameObject.SetActive(false);
        }
        else if (canSayaci == 2)
        {
            image1.gameObject.SetActive(true);
            image2.gameObject.SetActive(true);
            image3.gameObject.SetActive(false);
        }
    }

    public void CanEkle()
    {
        if (canSayaci > 0 && canSayaci < 3)
        {
            canSayaci += 1;

            if (canSayaci == 1)
            {
                image1.gameObject.SetActive(true);
                image2.gameObject.SetActive(false);
                image3.gameObject.SetActive(false);
            }
            else if(canSayaci == 2)
            {
                image1.gameObject.SetActive(true);
             image2.gameObject.SetActive(true);
                image3.gameObject.SetActive(false);
            }
            else if (canSayaci == 3)
            {
                image1.gameObject.SetActive(true);
                image2.gameObject.SetActive(true);
                image3.gameObject.SetActive(true);
            }
        }
    }
}
