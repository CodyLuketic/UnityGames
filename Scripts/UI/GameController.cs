using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] Score scoreScript;

    [SerializeField] GameObject loseScreen;

    [SerializeField] TextMeshProUGUI highScoreText;

    [SerializeField] AudioSource gameTheme;

    private float highScore;

    private Scene mainMenu;
    private Scene game;

    [System.NonSerialized] public bool gameHasEnded = false;

    private void Awake()
    {
        mainMenu = SceneManager.GetSceneByBuildIndex(0);
        game = SceneManager.GetSceneByBuildIndex(1);
    }

    public void Lost()
    {
        gameHasEnded = true;
        highScore = PlayerPrefs.GetFloat("High Score");

        if (highScore < scoreScript.bananasCaught)
        {
            PlayerPrefs.SetFloat("High Score", scoreScript.bananasCaught);
            highScoreText.text = PlayerPrefs.GetFloat("High Score").ToString();
        }

        if (loseScreen.activeSelf == false)
        {
            Time.timeScale = 0;

            loseScreen.SetActive(true);
            gameTheme.Stop();
        }
        else
        {
            loseScreen.SetActive(false);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        gameHasEnded = false;

        SceneManager.LoadScene("game");
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("mainMenu");
    }

    public void Game()
    {
        PlayerPrefs.SetFloat("High Score", 0);
        Time.timeScale = 1;
        gameHasEnded = false;

        SceneManager.LoadScene("game");
    }

    public void Quit()
    {
        PlayerPrefs.SetFloat("High Score", 0);

        Application.Quit();
    }
}
