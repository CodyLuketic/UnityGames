using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameController.Won();
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameController.Lost();

        }
    }
}
