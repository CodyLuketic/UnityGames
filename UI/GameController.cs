using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Scene mainMenu;
    private Scene intro;
    private Scene tutorial1;
    private Scene tutorial2;
    private Scene tutorial3;
    private Scene game;
    private Scene ending;
    private Scene endingScreen;

    private void Start()
    {
        mainMenu = SceneManager.GetSceneByBuildIndex(0);
        intro = SceneManager.GetSceneByBuildIndex(1);
        tutorial1 = SceneManager.GetSceneByBuildIndex(2);
        tutorial2 = SceneManager.GetSceneByBuildIndex(3);
        tutorial3 = SceneManager.GetSceneByBuildIndex(4);
        game = SceneManager.GetSceneByBuildIndex(5);
        ending = SceneManager.GetSceneByBuildIndex(6);
        endingScreen = SceneManager.GetSceneByBuildIndex(7);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void Intro()
    {
        SceneManager.LoadScene("intro");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("tutorial");
    }

    public void Game()
    {
        SceneManager.LoadScene("game");
    }

    public void Ending()
    {
        SceneManager.LoadScene("ending");
    }

    public void EndingScreen()
    {
        SceneManager.LoadScene("endingScreen");
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
