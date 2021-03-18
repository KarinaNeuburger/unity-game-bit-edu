using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{

    [SerializeField]
    private Text LoadLevelText;

    public static string LevelText;

    void Start()
    {
        LoadLevelText.text = LevelText; 
    }
}
