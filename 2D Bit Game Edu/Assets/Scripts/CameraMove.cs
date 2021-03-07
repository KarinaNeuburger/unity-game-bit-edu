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
            //Vector3 newPos = new Vector3(0, (float)-21.5, (float) -10);
            transform.position = newPos;
        }
    }
}
