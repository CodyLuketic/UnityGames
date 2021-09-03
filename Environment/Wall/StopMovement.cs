using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMovement : MonoBehaviour
{
    private void OnCollisionEnter2d(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
}
