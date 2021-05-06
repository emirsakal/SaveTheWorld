using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class speedKontrol : MonoBehaviour
{
    public Text balonText;
    public int patlayanBalon = 0;
    public int canSayaci = 1;
    public GameObject patlamacık;
    public UnityEngine.UI.Button btn;
    public UnityEngine.UI.Button btn1;
    public UnityEngine.UI.Button btn2;

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
    }
}
