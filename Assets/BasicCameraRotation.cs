using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCameraRotation : MonoBehaviour
{
    public void RotateUpDown(float axis)
    {
        transform.RotateAround(transform.position, transform.right, -axis * Time.deltaTime);
    }

    //rotate the camera rigt and left (y rotation)
    public void RotateRightLeft(float axis)
    {
        transform.RotateAround(transform.position, Vector3.up, -axis * Time.deltaTime);
    }
}
