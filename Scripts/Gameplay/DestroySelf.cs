using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    [SerializeField] float TimeToLive;
    void Start()
    {
        Destroy(gameObject, TimeToLive);
    }
}
