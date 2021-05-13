using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{

    public int comida = 0;
    public int lixo = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coletavel"))
        {
            Collect(collision.GetComponent<Coletavel>());
        }

        
    }
    private void Collect(Coletavel coletavel)
    {
        if (coletavel.Collect())
        {
            if (coletavel is Comida)
            {
                comida++;
            }

            if (coletavel is Lixo)
            {
                comida++;
            }
        }
        {

        }
    }
}
