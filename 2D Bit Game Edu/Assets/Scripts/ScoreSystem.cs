using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
    public Text scoreText;
    public Text lifeText;
    public Text gemText;
    public static int scorePoints = 0;
    public static int playerLifes = 3;
    public static int gemPoints = 0;
    public static Vector3 playerPositonOnLoad;

    void Start()
    {
        scoreText.text = "" + scorePoints + "  x  ";
        lifeText.text = "  x  " + playerLifes;

    }
    void FixedUpdate()
    {
        gemText.text = "" + gemPoints + "  x  ";
        lifeText.text = "  x  " + playerLifes;

        if (scorePoints == 3)
        {
            if (MapManager.load > MapManager.levelCompleted)
            {
                MapManager.levelCompleted++;
            }
            if (gemPoints == 15)
            {
                if (MapManager.load == 1)
                    MapManager.lv1_medal = true;
                if (MapManager.load == 2)
                    MapManager.lv2_medal = true;
                if (MapManager.load == 3)
                    MapManager.lv3_medal = true;
                if (MapManager.load == 4)
                    MapManager.lv4_medal = true;
                if (MapManager.load == 5)
                    MapManager.lv5_medal = true;
            }
            SceneManager.LoadScene("LevelCompleted");
        }

        if (playerLifes == 0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
}
