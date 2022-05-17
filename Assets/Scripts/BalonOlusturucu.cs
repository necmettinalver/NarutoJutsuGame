using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi=1f;
    float zamanSayaci=0f;
    ZamanPuan zpScripti;
    float katsayix=10f;

    // Start is called before the first frame update
    void Start()
    {
        zpScripti = this.gameObject.GetComponent<ZamanPuan>();
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        katsayix += Time.deltaTime;
        int katsayi = (int)katsayix/10;
        if (zamanSayaci<0 && zpScripti.zamanSayaci>0)
        {
            GameObject go = Instantiate(balon, new Vector3(Random.Range(-2.50f,2.96f),-6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 80f*katsayi, 0));
            zamanSayaci = balonOlusturmaSuresi;
        }
        
    }

}
