using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject score;

    public float meteorsReflected = 0;

    private void Update()
    {
        score.SetActive(false);
        score.GetComponent<TextMeshProUGUI>().text = meteorsReflected.ToString();
        score.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            meteorsReflected++;
        }
    }
}
