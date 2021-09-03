using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private Scene mainMenu;
    private Scene tutorial1;
    private Scene tutorial2;
    private Scene game;

    private void Start()
    {
        mainMenu = SceneManager.GetSceneByBuildIndex(0);
        tutorial1 = SceneManager.GetSceneByBuildIndex(1);
        tutorial2 = SceneManager.GetSceneByBuildIndex(2);
        game = SceneManager.GetSceneByBuildIndex(3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void Tutorial1()
    {
        SceneManager.LoadScene("tutorial1");
    }

    public void Tutorial2()
    {
        SceneManager.LoadScene("tutorial2");
    }

    public void Game()
    {
        SceneManager.LoadScene("game");
    }

    public void CurrentScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void NextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
