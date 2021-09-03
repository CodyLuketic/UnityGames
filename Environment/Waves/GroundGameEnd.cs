using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundGameEnd : MonoBehaviour
{
    private float meteorLandCount;

    [SerializeField] private GameObject endCanvas;

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Meteor")){

            if(meteorLandCount == 5){
                endCanvas.SetActive(true);
                Time.timeScale = 0;
            }
            else{
                Destroy(other.gameObject);
                meteorLandCount++;
            }
        }
    }
}
