using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyMeteor : MonoBehaviour
{
    private float length;
    [SerializeField] private float height;

    void Awake(){
        length = Random.Range(-15, 15);
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
            GameObject newMeteor = Instantiate(gameObject, new Vector3(length, height, 0), gameObject.transform.rotation);
        }
    }
}
