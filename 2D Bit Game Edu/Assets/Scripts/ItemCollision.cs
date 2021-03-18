using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemCollision : MonoBehaviour
{
    public static int index = 0;
    public static string objName; 
    private GameObject playerObj = null;
    public static bool hasCollided = false;
    public static List<string> questionDestroyer = new List<string>();
    private GameObject questionIcon = null;

    void Start()
    {
        foreach (string question in questionDestroyer)
        {
            Debug.Log("Teste" + question);
            string questionName = "" + question;
            questionIcon = GameObject.Find(questionName);
            Destroy(questionIcon);
        }
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {

        if (collider.gameObject.name == "Player")
        {
            
            hasCollided = true;
            string getIndex = gameObject.name;
            objName = gameObject.name;
            char test = getIndex[getIndex.Length - 1];
            int.TryParse("" + test, out index);
            index--;
            
            if (MapManager.load > 2 && MapManager.load < 5 && index >= 0)
            {
                index += 10;
            }
            if (MapManager.load == 2 && index < 0)
            {
                index += 10;
            }
            if(MapManager.load == 5)
            {
                index += 20;
            }
            if (MapManager.load == 4 && index < 0)
            {
                index += 20;
            }

            questionDestroyer.Add(gameObject.name);
            Destroy(gameObject);
            Debug.Log("Pontos" + ScoreSystem.scorePoints);

            if (playerObj == null)
            {
                playerObj = GameObject.Find("Player");
            }
            
            ScoreSystem.playerPositonOnLoad = playerObj.transform.position;
            SceneManager.LoadScene("Quiz");

        }
    }
}
