using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{

    public TextMeshProUGUI hiScoreLabel;
    public TMP_InputField nameField;

    private void Start()
    {
        Player.Instance.LoadPlayer(SaveSystem.LoadPlayer());
        hiScoreLabel.text = $"HiScore: {Player.Instance.HiScore}";
        nameField.text = Player.Instance.PlayerName;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
