using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string playerName;
    public int hiScore;

    public PlayerData()
    {
        playerName = "";
        hiScore = 0;
    }

    public PlayerData(Player player)
    {
        playerName = player.PlayerName;
        hiScore = player.HiScore;
    }
}