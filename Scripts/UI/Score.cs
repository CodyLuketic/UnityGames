using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] GameController gameController;

    [SerializeField] TextMeshProUGUI TextPro;

    public float score = 0;

    // Update is called once per frame
    private void Update()
    {
        ScoreGain();
    }

    private void ScoreGain()
    {
        if (!gameController.gameHasEnded)
        {
            score += 1;
            TextPro.text = score.ToString();
        }
    }
}
