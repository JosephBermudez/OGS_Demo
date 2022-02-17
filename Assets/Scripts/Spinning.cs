//Script Created by Jose Bermudez. 2/15/2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    private Vector2 startPos, direction;
    private float multiplierY = 0.02f;
    private float multiplierX = 0.02f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    direction = Vector3.zero;
                    break;

                case TouchPhase.Moved:
                    direction = touch.position - startPos;
                    if (direction.magnitude > 0.05f)
                    {
                        // var localAngles=this.transform.localEulerAngles;
                        // localAngles.y+=direction.y*multiplierY;
                        // this.transform.localEulerAngles=localAngles;

                        var globalAngles = this.transform.eulerAngles;
                        globalAngles.y += -direction.x * multiplierX;
                        this.transform.eulerAngles = globalAngles;

                        var dotVal1 = Vector3.Dot(Camera.main.transform.forward, this.transform.right);
                        var dotVal2 = Vector3.Dot(Camera.main.transform.forward, this.transform.up);
                        var dotVal3 = Vector3.Dot(Camera.main.transform.right, this.transform.up);


                        // Debug.Log("Value"+(dotVal>0?true:false));
                        // MyDebug.Log("Value"+(dotVal>0?true:false));

                        this.transform.localRotation *= Quaternion.Euler(0, -direction.y * multiplierY * (dotVal1 > 0 ? -1 : 1) * (dotVal1 > 0 ? -1 : 1) * (dotVal3 > 0 ? -1 : 1), 0);
                    }
                    break;

                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    break;
            }
        }
    }
}
