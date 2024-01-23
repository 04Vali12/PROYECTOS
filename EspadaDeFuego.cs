using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaDeFuego : ArmasDoradas
{
    void start()
    {
        ataque = 10;
        recistencia = 20;
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
    
}
