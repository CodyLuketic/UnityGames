using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    bool flag = true;

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        float sceneNumber = currentScene.buildIndex;

        if (sceneNumber == 18 && flag == true)
        {
            gameManager.CompleteLevel();
            flag = false;
        }
        else
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
