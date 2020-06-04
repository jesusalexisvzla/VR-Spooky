using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarObjetos : MonoBehaviour
{

    int cont = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (cont == 1)
        {
            transform.Rotate(new Vector3(-85f, 0f, 0f) * Time.deltaTime);
            cont = 2;

        }


    }

    public void rotar()
    {
      transform.Rotate(new Vector3(0f, 0f, 2850) * Time.deltaTime);
        transform.Translate(new Vector3(0f, 5f, 0f) * Time.deltaTime);


    }
}
