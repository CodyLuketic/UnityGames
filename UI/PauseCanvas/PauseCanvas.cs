using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCanvas : MonoBehaviour
{
    [SerializeField] private GameObject holder;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Tab)){
            ToggleMenuOn();
        }
    }

    public void ToggleMenuOn() {
        holder.SetActive(true);
        Time.timeScale = 0;
    }

    public void ToggleMenuOff() {
        holder.SetActive(false);
        Time.timeScale = 1;
    }
}
