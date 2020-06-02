using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllers : MonoBehaviour
{
    private Transform myTransform;
    public float speed;
    private float xAxis,zAxis;
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.W))
        // {
        //   myTransform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
        // }

        xAxis = Input.GetAxis("Horizontal");
        zAxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(xAxis, 0, zAxis);
        myTransform.Translate(movement * speed * Time.deltaTime);
    }
}
