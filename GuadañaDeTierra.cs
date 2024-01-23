using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuadañaDeTierra: ArmasDoradas
{
    void start()
    {
        ataque = 16;
        recistencia = 25;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            TotalDamage = MobLife - AttackDamage;
            Debug.Log("Golpe exitoso");
        }
        else
        {
            return;
        }
    }
