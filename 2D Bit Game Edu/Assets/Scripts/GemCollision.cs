using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollision : MonoBehaviour
{
    public static List<string> gemDestroyer = new List<string>();
    private GameObject gemIcon = null;

    private void OnCollisionEnter2D(Collision2D collider)
    {

        if (collider.gameObject.name == "Player")
        {
            gemDestroyer.Add(gameObject.name);
            Destroy(gameObject);

            updateScore();

        }
    }

    void Start ()
    {
        foreach (string gem in gemDestroyer)
        {
            string gemName = "" + gem;
            gemIcon = GameObject.Find(gemName);
            Destroy(gemIcon);
        }
    }

    public void updateScore()
    {
        ScoreSystem.gemPoints++;
    }
}
