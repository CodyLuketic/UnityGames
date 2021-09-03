using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCinematic : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    [SerializeField] private GameObject canvas;

    [SerializeField] private float waitTimeForCanvas;
    [SerializeField] private float waitTimeForNextScene;

    void Start()
    {
        StartCoroutine(SetCanvasActive());
        StartCoroutine(NextScene());
    }

    private IEnumerator SetCanvasActive()
    {
        yield return new WaitForSeconds(waitTimeForCanvas);

        canvas.SetActive(true);
    }

    private IEnumerator NextScene()
    {
        yield return new WaitForSeconds(waitTimeForNextScene);

        gameController.NextScene();
    }
}
