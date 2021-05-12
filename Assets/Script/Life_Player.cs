using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_Player : MonoBehaviour
{
    public int qtdLife = 10;
    public Slider lifeSlider;
    void Start()
    {
        lifeSlider.value = qtdLife;
    }

    //public void Dano() {
    //    lifeSlider.value -= 1;
    //}

    public void Recarga()
    {
        lifeSlider.value += 1;
    }
}
