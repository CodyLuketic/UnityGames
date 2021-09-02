using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void Update()
    {
        Invoke("DestroyPoints", 10f);
    }

    private void DestroyPoints()
    {
        Destroy(gameObject);
    }
}
