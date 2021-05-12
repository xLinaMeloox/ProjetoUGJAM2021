using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fome : MonoBehaviour
{

    public Slider fomeSlider;
    public int qtnFome = 10;
    float tempoDeFome;
    float tempoDevida;
    public Life_Player vida;

    
    void Start()
    {
        fomeSlider.value = qtnFome;
        fomeSlider.maxValue = qtnFome;
        vida.lifeSlider.maxValue = vida.qtdLife;
        tempoDeFome = qtnFome;
        tempoDevida = vida.qtdLife;
        
    }

    // Update is called once per frame
    void Update()
    {
        tempoDeFome -= Time.deltaTime;
        fomeSlider.value = tempoDeFome;

        if (fomeSlider.value <=0)
        {
            tempoDevida -= Time.deltaTime;
            vida.lifeSlider.value = tempoDevida;
        }
      
    }
    public void Comer()
    {
        tempoDeFome += 5;
    }
}
