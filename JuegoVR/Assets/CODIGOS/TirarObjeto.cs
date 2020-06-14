using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirarObjeto : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objeto;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objeto.GetComponent<Rigidbody>().useGravity = true;
        }
    }



}
