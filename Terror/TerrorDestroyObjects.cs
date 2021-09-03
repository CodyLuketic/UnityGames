using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrorDestroyObjects : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameController.Lost();
        }

        if (!collision.gameObject.CompareTag("Wall") && !collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
