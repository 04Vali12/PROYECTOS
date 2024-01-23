using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikensDeHielo : ArmasDoradas
{
    void start()
    {
        ataque = 16;
        recistencia = 18;
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
