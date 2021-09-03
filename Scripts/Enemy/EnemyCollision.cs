using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] GameController gameController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Earth"))
        {
            Destroy(gameObject);
        }
    }


}
