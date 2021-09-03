using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoNextScene : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    [SerializeField] private float waitTime;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(GoToNextScene());
    }

    private IEnumerator GoToNextScene()
    {
        yield return new WaitForSeconds(waitTime);

        gameController.EndingScreen();
    }
}
