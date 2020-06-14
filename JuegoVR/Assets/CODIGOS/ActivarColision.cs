using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarColision : MonoBehaviour
{

    public GameObject objeto;
    public GameObject objeto2;
    public GameObject objeto3;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objeto.SetActive(true);
            objeto2.SetActive(true);
            objeto3.SetActive(true);
        }
    }


}
