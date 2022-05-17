using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama;
    ZamanPuan scripti;
    void Start()
    {
        scripti = GameObject.Find("Scripts").GetComponent<ZamanPuan>(); 
    }

    void OnMouseDown()
    {
        GameObject go =  Instantiate(patlama,transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.9f);
        scripti.patlamaSay();
    }

}
