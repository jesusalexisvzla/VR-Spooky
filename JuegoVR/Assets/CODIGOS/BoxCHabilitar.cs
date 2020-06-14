using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCHabilitar : MonoBehaviour

{
    public GameObject objeto;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objeto.GetComponent<BoxCollider>().enabled = true;
        }
    }



}
