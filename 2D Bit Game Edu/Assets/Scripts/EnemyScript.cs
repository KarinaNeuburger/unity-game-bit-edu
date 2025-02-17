﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            collider.gameObject.transform.position = PlayerMovement.playerTeleportPosition;
            ScoreSystem.playerLifes--;
        }
    }
}
