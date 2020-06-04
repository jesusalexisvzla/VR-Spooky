using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Rendimiento : MonoBehaviour
{
    [SerializeField]
    float factor = 0.5f;
    void Start()
    {
        Screen.SetResolution(
            Mathf.CeilToInt(Screen.currentResolution.width * factor),
             Mathf.CeilToInt(Screen.currentResolution.height * factor),
             true);
    }

   
    
}
