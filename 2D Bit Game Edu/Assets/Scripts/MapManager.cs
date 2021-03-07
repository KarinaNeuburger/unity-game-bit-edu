using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public static int levelCompleted;
    public static int load = 0;
    public static bool lv1_medal;
    public static bool lv2_medal;
    public static bool lv3_medal;
    public static bool lv4_medal;
    public static bool lv5_medal;

    private GameObject gameObj;
    private GameObject medal1;
    private GameObject medal2;
    private GameObject medal3;
    private GameObject medal4;
    private GameObject medal5;

    private void Start()
    {
        SaveSystem.SaveProgress();
        CameraMove.newPos = new Vector3(0, 0, -10);
        PlayerMovement.playerTeleportPosition = new Vector3(-9f, -5f, 0);
        ScoreSystem.scorePoints = 0;
        ScoreSystem.playerLifes = 3;
        ScoreSystem.gemPoints = 0;
        ItemCollision.index = 0;
        ItemCollision.hasCollided = false;
        ItemCollision.questionDestroyer.Clear();
        GemCollision.gemDestroyer.Clear();

        Debug.Log("MapManager Start Method" + levelCompleted + lv1_medal + lv2_medal + lv3_medal +
            lv4_medal + lv5_medal);

        medal1 = GameObject.Find("gem_medal_lv1");
        medal2 = GameObject.Find("gem_medal_lv2");
        medal3 = GameObject.Find("gem_medal_lv3");
        medal4 = GameObject.Find("gem_medal_lv4");
        medal5 = GameObject.Find("gem_medal_lv5");

        if (lv1_medal == false)
        {
            medal1.SetActive(false);
        }
        if (lv2_medal == false)
        {
            medal2.SetActive(false);
        }
        if (lv3_medal == false)
        {
            medal3.SetActive(false);
        }
        if (lv4_medal == false)
        {
            medal4.SetActive(false);
        }
        if (lv5_medal == false)
        {
            medal5.SetActive(false);
        }

        for (int i = 2+levelCompleted; i <= 5; i++)
        {
            gameObj = GameObject.Find("Level" + i);
            gameObj.SetActive(false);
            gameObj = null;
        }
        for (int i = 1; i <= levelCompleted +1; i++)
        {
            gameObj = GameObject.Find("Lock" + i);
            Destroy(gameObj);
        }
    }  
     
    public void LoadLevel1()
    {
        load = 1;
        LoadText.LevelText ="1ª Fase\nNavegação Segura";
        SceneManager.LoadScene("LoadLevel");
    }
    public void LoadLevel2()
    {
        load = 2;
        LoadText.LevelText = "2ª Fase\nInformações Pessoais";
        SceneManager.LoadScene("LoadLevel");
    }
    public void LoadLevel3()
    {
        load = 3;
        LoadText.LevelText = "3ª Fase\nSegurança dos Aparelhos";
        SceneManager.LoadScene("LoadLevel");
    }
    public void LoadLevel4()
    {
        load = 4;
        LoadText.LevelText = "4ª Fase\nCyberbullying e pessoas mal intencionadas";
        SceneManager.LoadScene("LoadLevel");
    }
    public void LoadLevel5()
    {
        load = 5;
        LoadText.LevelText = "5ª Fase\nGolpes e software malicioso";
        SceneManager.LoadScene("LoadLevel");
    }

}
