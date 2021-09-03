using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    [SerializeField] private GameObject canvas;

    [SerializeField] private float waitTimeForNextScene;

    void Update()
    {
        if(GetComponent<Renderer>().material.color == Color.blue)
        {
            canvas.SetActive(true);

            StartCoroutine(NextScene());
        }
    }

    private IEnumerator NextScene()
    {
        yield return new WaitForSeconds(waitTimeForNextScene);

        gameController.Ending();
    }
}
