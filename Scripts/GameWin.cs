using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    [SerializeField] GameController gameController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.Win();
    }
}
