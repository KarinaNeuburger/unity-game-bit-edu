using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;

    //public static List<int> questionDestroyer = new List<int>();
    //public static List<string> questionDestroyer = new List<string>();
    public static Vector3 playerTeleportPosition = new Vector3(-9.25f, -5.5f, 0);
	public float runSpeed = 40f;
    private GameObject playerObj = null;
    private GameObject questionIcon = null;

    float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

    void Start()
    {

        if (ItemCollision.hasCollided == true)
        {
            if (playerObj == null)
            {
                playerObj = GameObject.Find("Player");
            }

            playerObj.transform.position = ScoreSystem.playerPositonOnLoad;
           
        }
    }

    // Update is called once per frame
    void Update() {

        if (CameraMove.moveCamera == true && PlayerTeleport.portalCollision == true)
        {
            playerObj = GameObject.Find("Player");
            //Vector3 playerTeleportPosition = new Vector3((float)-11.28, (float)-25.6, 0);
            Debug.Log("Teste de movimento do jogador");
            playerObj.transform.position = playerTeleportPosition;
            PlayerTeleport.portalCollision = false;
        }

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
	}

    void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}
