using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZamanPuan : MonoBehaviour
{
    public UnityEngine.UI.Text balonText, zamanText;
    public float zamanSayaci=60;
    int balonSayaci=0;
    public GameObject patlama;
    // Start is called before the first frame update
    void Start()
    {
        balonText.text = "Puan :" + balonSayaci;
        zamanText.text = "Zaman :" + (int)zamanSayaci;
    }

    // Update is called once per frame
    void Update()
    {
        if (zamanSayaci>0)
        {
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "Zaman :" + (int)zamanSayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("BalonSay");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }
    }

    public void patlamaSay()
    {
        balonSayaci = balonSayaci + 1;
        balonText.text = "Puan :" + balonSayaci;

    }
}
