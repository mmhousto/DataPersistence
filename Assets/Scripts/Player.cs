using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    public string PlayerName { get; private set; }
    public int HiScore { get; private set; }

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadPlayer(PlayerData data)
    {
        PlayerName = data.playerName;
        HiScore = data.hiScore;
    }

    public void SetPlayerName(string name)
    {
        PlayerName = name;
        SaveSystem.SavePlayer(Instance);
    }

    public void SetHiScore(int newScore)
    {
        HiScore = newScore;
        SaveSystem.SavePlayer(Instance);
    }
}
