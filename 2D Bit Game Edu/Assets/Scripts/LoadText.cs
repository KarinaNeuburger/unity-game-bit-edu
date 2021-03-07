using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{

    [SerializeField]
    private Text LoadLevelText;

    public static string LevelText;
    // Start is called before the first frame update
    void Start()
    {
        LoadLevelText.text = LevelText; 
    }
}
