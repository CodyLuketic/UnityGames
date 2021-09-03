using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private float hitCount;

    private void Start()
    {
        StartCoroutine(ResetColor());
    }

    void Update()
    {
        ChangeColor();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.magenta;

        hitCount++;
    }

    private void ChangeColor()
    {
        if (hitCount >= 10)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    private IEnumerator ResetColor()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
