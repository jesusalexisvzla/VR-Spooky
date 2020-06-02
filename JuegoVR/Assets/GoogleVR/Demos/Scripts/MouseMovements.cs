using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoves : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Vector2 touchDeltaPosition;
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float pointer_y = Input.GetAxis("Mouse X");
            float pointer_x = Input.GetAxis("Mouse Y");
            gameObject.transform.Rotate(pointer_x * 2, pointer_y * 2, 0);
        }
         if(Input.touchCount == 1){
            Touch touchZero = Input.GetTouch(0);
            if (touchZero.phase == TouchPhase.Moved)
            {
                touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                gameObject.transform.Rotate(touchDeltaPosition.y * .05f, -touchDeltaPosition.x * .4f, 0);
            }
        }
    }
}
