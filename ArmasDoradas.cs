using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    BASE = 0,
    FUEGO = 1,
    TIERRA = 2,
    RAYO = 3,
    HIELO = 4,
}

public class ArmasDoradas : MonoBehaviour
{
    class ArmaDorada
    {
        public Sprite icon;
        public Type type;
        public string nombre;
        public int resistencia;
        public int ataque;

    }
    public void Start()
    {
        GetComponent<SpriteRenderer>().sprite = icon;
    }

    public virtual void Setup(string _nombre, int _ataque, int _resistencia)
    {
        Nombre = _nombre;
        Ataque = _ataque;
        Resistencia = _resistencia;
        GetComponent<SpriteRenderer>().sprite = icon;
    }

    public virtual int GetAttack() { return 0; }
    
}
