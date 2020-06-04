using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opttimizar : MonoBehaviour
{
    public int fuerza;
    public CapsuleCollider capsuleCollider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (capsuleCollider.radius>1)
        {
            GetComponent<Rigidbody>().AddForce(0, 1, 0);
        }
        
    }
}
