using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] GameObject score;
    [SerializeField] TextMeshProUGUI scoreText;

    public float bananasCaught = 0;

    private void Update()
    {
        score.SetActive(false);
        score.GetComponent<TextMeshProUGUI>().text = bananasCaught.ToString();
        score.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("banana"))
        {
            Destroy(collision.gameObject);
            bananasCaught++;
        }
    }
}
