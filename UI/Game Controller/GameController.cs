using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Scene mainMenu;
    private Scene settings;
    private Scene intro;
    private Scene game;
    private Scene won;
    private Scene lost;

    [Header("Beating To Split Heart Transition Components")]
    [SerializeField] private GameObject beatingHeart;
    [SerializeField] private GameObject maleSplit;
    [SerializeField] private GameObject femaleSplit;
    [SerializeField] private GameObject tether;
    [Space]

    [Header("Values")]
    [SerializeField] private float animationTime;
    [SerializeField] private float timeToStart;

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1) {
            Invoke("BeatingToSplitHeartTransition", animationTime);
            Invoke("Game", timeToStart);
        }
    }

    private void Start()
    {
        mainMenu = SceneManager.GetSceneByBuildIndex(0);
        intro = SceneManager.GetSceneByBuildIndex(1);
        game = SceneManager.GetSceneByBuildIndex(2);
        won = SceneManager.GetSceneByBuildIndex(3);
        lost = SceneManager.GetSceneByBuildIndex(4);
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

    public void Game()
    {
        SceneManager.LoadScene("game");
    }

    public void Won()
    {
        SceneManager.LoadScene("won");
    }

    public void Lost()
    {
        SceneManager.LoadScene("lost");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void BeatingToSplitHeartTransition()
    {
        if (beatingHeart != null & maleSplit != null & femaleSplit != null)
        {
            beatingHeart.SetActive(false);

            maleSplit.SetActive(true);
            femaleSplit.SetActive(true);
            tether.SetActive(true);
        }
    }
}
