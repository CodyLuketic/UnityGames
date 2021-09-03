using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = GameObject.FindGameObjectsWithTag("Meteor").Length.ToString();
    }
}
