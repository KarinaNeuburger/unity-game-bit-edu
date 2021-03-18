using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public static bool moveCamera = false;
    public static Vector3 newPos;

    void Update()
    {
        if (moveCamera == true)
        {
            transform.position = newPos;
        }
    }
}
