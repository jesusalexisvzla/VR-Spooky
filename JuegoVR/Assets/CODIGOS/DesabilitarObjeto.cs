using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesabilitarObjeto : MonoBehaviour
{
    public GameObject objeto;
    void Start()
    {
        objeto.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void habilitar()
    {
        objeto.gameObject.SetActive(true);

    }

    public void desabilitar()
    {
        objeto.gameObject.SetActive(false);

    }
}