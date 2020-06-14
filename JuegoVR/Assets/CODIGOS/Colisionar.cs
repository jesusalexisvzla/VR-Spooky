using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisionar : MonoBehaviour
{

    public GameObject objeto1;
    public GameObject objeto2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            objeto1.SetActive(true);
            objeto2.SetActive(true);

        }
    }


}
