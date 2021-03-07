using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscQuit : MonoBehaviour
{
    private GameObject canvasPanel;

    void Start()
    {
        canvasPanel = GameObject.Find("Canvas_Panel");
        canvasPanel.SetActive(false);
    }
    public void EscPressed()
    {
        canvasPanel.SetActive(true);
    }
    public void Panel_Yes()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Panel_No()
    {
        canvasPanel.SetActive(false);
    }
    public void Panel_Cancel()
    {
        canvasPanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscPressed();
            Debug.Log("Esc");
        }
    }
}
