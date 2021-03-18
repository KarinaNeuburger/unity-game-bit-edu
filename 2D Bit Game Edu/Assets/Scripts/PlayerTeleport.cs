using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public static bool portalCollision = false;

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "Portal1-1-2" || 
            collider.gameObject.name == "Portal2-1-2" ||
            collider.gameObject.name == "Portal3-1-2" ||
            collider.gameObject.name == "Portal4-1-2" ||
            collider.gameObject.name == "Portal5-1-2")
        {
            CameraMove.newPos = new Vector3(0, -21.5f, -10f);
            PlayerMovement.playerTeleportPosition = new Vector3(-10f, -24f, 0);
            CameraMove.moveCamera = true;
            portalCollision = true;
            Debug.Log("" + gameObject.name);

        }
        if (collider.gameObject.name == "Portal1-2-3" || 
            collider.gameObject.name == "Portal2-2-3" ||
            collider.gameObject.name == "Portal3-2-3" ||
            collider.gameObject.name == "Portal4-2-3" ||
            collider.gameObject.name == "Portal5-2-3")
        {
            CameraMove.newPos = new Vector3(40, 0, -10);
            PlayerMovement.playerTeleportPosition = new Vector3(28f, 1.5f, 0);
            CameraMove.moveCamera = true;
            portalCollision = true;
            Debug.Log("" + gameObject.name);
        }
        if (collider.gameObject.name == "Portal1-2-1" || 
            collider.gameObject.name == "Portal2-2-1" ||
            collider.gameObject.name == "Portal3-2-1" ||
            collider.gameObject.name == "Portal4-2-1" ||
            collider.gameObject.name == "Portal5-2-1")
        {
            CameraMove.newPos = new Vector3(0, 0, -10);
            PlayerMovement.playerTeleportPosition = new Vector3(-9f,-5f, 0);
            CameraMove.moveCamera = true;
            portalCollision = true;
            Debug.Log("" + gameObject.name);
        }
        if (collider.gameObject.name == "Portal1-3-2" || 
            collider.gameObject.name == "Portal2-3-2" ||
            collider.gameObject.name == "Portal3-3-2" ||
            collider.gameObject.name == "Portal4-3-2" ||
            collider.gameObject.name == "Portal5-3-2")
        {
            CameraMove.newPos = new Vector3(0, -21.5f, -10);
            PlayerMovement.playerTeleportPosition = new Vector3(7.6f, -24.2f, 0);
            CameraMove.moveCamera = true;
            portalCollision = true;
            Debug.Log("" + gameObject.name);
        }
    }
}
