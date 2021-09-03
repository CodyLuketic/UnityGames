using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] Score score;

    private Scene game;
    private Scene lost;

    private void Awake()
    {
        game = SceneManager.GetSceneByBuildIndex(1);
        lost = SceneManager.GetSceneByBuildIndex(2);
    }

    public void Lost()
    {
        SceneManager.LoadScene("lost");
    }

    public void Game()
    {
        SceneManager.LoadScene("game");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
