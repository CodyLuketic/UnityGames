using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject lossScreen;
    [SerializeField] GameObject winScreen;

    [SerializeField] AudioSource gameTheme;

    private Scene mainMenu;
    private Scene game;

    private void Awake()
    {
        mainMenu = SceneManager.GetSceneByBuildIndex(0);
        game = SceneManager.GetSceneByBuildIndex(1);
    }
    public void Lost()
    {
        Time.timeScale = 0;

        lossScreen.SetActive(true);
        gameTheme.Stop();
    }

    public void Restart()
    {
        SceneManager.LoadScene("game");

        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");

        Time.timeScale = 1;
    }

    public void Game()
    {
        SceneManager.LoadScene("game");

        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Win()
    {
        winScreen.SetActive(true);
    }
}
