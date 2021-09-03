using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAgain : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pit")){
            gameController.Game();
        }
    }
}
