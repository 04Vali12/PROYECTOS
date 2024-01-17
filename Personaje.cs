using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : Heroe
{
    public bool isDead;
    public Heroe GetHeroe()
    {
        return alive;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (isDead)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}