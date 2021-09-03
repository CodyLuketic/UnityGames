using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GunnerInput : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float strafe;

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        float sceneNumber = currentScene.buildIndex;

        Movement();

        if (sceneNumber <= 5)
        {
            AutomaticMovement();
        }
        else if (sceneNumber > 5 && sceneNumber <= 12)
        {
            Combat();
            Shooting();
        }
        else if (sceneNumber > 12)
        {
            Combat();
            Shooting();
            FollowMouse();
        }
    }
    void AutomaticMovement()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
    void Movement()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * strafe, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * strafe, Space.World);
        }
    }

    void Combat()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed, Space.World);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed, Space.World);
        }
    }

    [SerializeField] GameObject projectile;
    GameObject projectileClone;
    [SerializeField] GameObject projectileSpawner;

    void Shooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            projectileClone = Instantiate(projectile, new Vector2(projectileSpawner.transform.position.x, projectileSpawner.transform.position.y), projectileSpawner.transform.rotation) as GameObject;
        }
    }

    void FollowMouse()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
    }
}

