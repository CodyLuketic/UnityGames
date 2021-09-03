using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TextPro;

    // Update is called once per frame
    private void Update()
    {
        TextPro.text = PlayerPrefs.GetFloat("High Score").ToString();
    }
}
