using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionarDesactivarObjeto : MonoBehaviour
{

    public GameObject objeto;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;
    public GameObject objeto5;
    public GameObject objeto6;
    public GameObject objeto7;
    public GameObject objeto8;
    public GameObject objeto9;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objeto.SetActive(false);
            objeto2.SetActive(false);
            objeto3.SetActive(false);
            objeto4.SetActive(false);
            objeto5.SetActive(false);
            objeto6.SetActive(false);
            objeto7.SetActive(false);
            objeto8.SetActive(false);
            objeto9.SetActive(false);


        }
    }


}
