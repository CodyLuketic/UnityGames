using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscenes : MonoBehaviour
{
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject focusCam;

    [SerializeField] GameObject speech;

    [SerializeField] GameObject boss;
    [SerializeField] GameObject player;
    [SerializeField] GameObject minions;
    [SerializeField] GameObject end;

    [SerializeField] GameObject cutStart;
    [SerializeField] GameObject cutEnd;

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        float sceneNumber = currentScene.buildIndex;

        if (sceneNumber == 18)
        {
            cutStart.SetActive(true);

            if (speech == false && boss == false)
            {
                focusCam.SetActive(true);
                cutStart.SetActive(false);
                mainCam.SetActive(false);
                player.GetComponent<GunnerInput>().enabled = false;
                cutEnd.SetActive(true);

                Invoke(nameof(End), 7.1f);
            }
            else if (speech == false)
            {
                player.GetComponent<GunnerInput>().enabled = true;
                mainCam.SetActive(true);
                focusCam.SetActive(false);
                minions.SetActive(true);
            }
        }
        else if (sceneNumber == 19)
        {
            if (boss == false)
            {
                focusCam.SetActive(true);
                cutStart.SetActive(false);
                mainCam.SetActive(false);
                player.GetComponent<GunnerInput>().enabled = false;
                cutEnd.SetActive(true);

                Invoke(nameof(End), 7.1f);
            }
        }
    }

    void End()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        float sceneNumber = currentScene.buildIndex;

        if (sceneNumber == 18)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        else if (sceneNumber == 19)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
