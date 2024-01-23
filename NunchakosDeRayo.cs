using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NunchakosDeRayo : ArmasDoradas
{
    void start()
    {
        ataque = 18;
        recistencia = 15;
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
