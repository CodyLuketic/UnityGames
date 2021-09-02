using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] GameController gameController;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        gameController.Lost();
    }
}
