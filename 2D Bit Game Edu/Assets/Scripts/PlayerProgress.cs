using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerProgress
{
    public int levelCompleted;
    public bool lv1_medal;
    public bool lv2_medal;
    public bool lv3_medal;
    public bool lv4_medal;
    public bool lv5_medal;

    public PlayerProgress ()
    {
        levelCompleted = MapManager.levelCompleted;
        lv1_medal = MapManager.lv1_medal;
        lv2_medal = MapManager.lv2_medal;
        lv3_medal = MapManager.lv3_medal;
        lv4_medal = MapManager.lv4_medal;
        lv5_medal = MapManager.lv5_medal;
    }
}
