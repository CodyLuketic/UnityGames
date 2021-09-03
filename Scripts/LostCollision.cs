using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostCollision : MonoBehaviour
{
    [SerializeField] GameController gameController;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Obstacle"))
        {
            gameController.Lost();
        }
    }
}
