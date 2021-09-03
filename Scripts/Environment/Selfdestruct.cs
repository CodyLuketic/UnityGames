using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selfdestruct : MonoBehaviour
{
    [SerializeField] float deathTime;

    void Update()
    {
        SelfDestruct();
    }

    private void SelfDestruct()
    {
        Destroy(this.gameObject, deathTime);
    }
}
