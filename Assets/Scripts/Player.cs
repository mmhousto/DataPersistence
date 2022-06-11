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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerName(string name)
    {
        PlayerName = name;
    }

    public void SetHiScore(int newScore)
    {
        HiScore = newScore;
    }
}
