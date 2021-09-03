using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Scene mainMenu;
    private Scene settings;
    private Scene opening;
    private Scene ending;
    private Scene lost;

    private void Start()
    {
        mainMenu = SceneManager.GetSceneByBuildIndex(0);
        opening = SceneManager.GetSceneByBuildIndex(2);
        ending = SceneManager.GetSceneByBuildIndex(8);
        lost = SceneManager.GetSceneByBuildIndex(9);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void Settings()
    {
        SceneManager.LoadScene("settings");
    }

    public void Intro()
    {
        SceneManager.LoadScene("intro");
    }

    public void Opening()
    {
        SceneManager.LoadScene("opening");
    }

    public void Ending()
    {
        SceneManager.LoadScene("Ending");
    }

    public void Lost()
    {
        SceneManager.LoadScene("lost");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
