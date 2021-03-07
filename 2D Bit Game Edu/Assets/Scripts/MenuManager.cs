using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private GameObject canvasPanel;
    void Start()
    {
        canvasPanel = GameObject.Find("Canvas_Panel");
        canvasPanel.SetActive(false);
    }
    public void NewGame()
    {
        canvasPanel.SetActive(true);
    }
    public void Panel_Yes()
    {
        SceneManager.LoadScene("Dialog");
    }
    public void Panel_No()
    {
        canvasPanel.SetActive(false);
    }
    public void Panel_Cancel()
    {
        canvasPanel.SetActive(false);
    }
    public void LoadGame()
    {
        PlayerProgress progress = SaveSystem.LoadProgress();

        MapManager.levelCompleted = progress.levelCompleted;
        MapManager.lv1_medal = progress.lv1_medal;
        MapManager.lv2_medal = progress.lv2_medal;
        MapManager.lv3_medal = progress.lv3_medal;
        MapManager.lv4_medal = progress.lv4_medal;
        MapManager.lv5_medal = progress.lv5_medal;

        SceneManager.LoadScene("Map");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
