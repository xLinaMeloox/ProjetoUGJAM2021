using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public bool isCollected = false;
    public bool Collect()
    {
        if (isCollected)
        {

            return false;
        }

        isCollected = true;
        Destroy(gameObject);
        return true;

    }
}
