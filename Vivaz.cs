using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vivaz : MonoBehaviour
{
    Alive alive = new Alive();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) DeadButton();
    }

    
    public void DeadButton()
    {
        alive.heal = alive - 1;
        Debug.Log(alive.GetHeal());
    }
}
