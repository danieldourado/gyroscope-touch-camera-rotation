using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCameraRotation : BasicCameraRotation
{
    Vector3 firstPoint;
    float sensitivity = 2.5f;

    void Update()
    {
       TouchRotation();
    }
    void TouchRotation()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                firstPoint = Input.GetTouch(0).position;
            }
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector3 secondPoint = Input.GetTouch(0).position;

                float x = FilterGyroValues(secondPoint.x - firstPoint.x);
                RotateRightLeft(x * sensitivity);

                float y = FilterGyroValues(secondPoint.y - firstPoint.y);
                RotateUpDown(y * -sensitivity);

                firstPoint = secondPoint;
            }
        }
    }
    float FilterGyroValues(float axis)
    {
        float thresshold = 0.5f;
        if (axis < -thresshold || axis > thresshold)
        {
            return axis;
        }
        else
        {
            return 0;
        }
    }
}
