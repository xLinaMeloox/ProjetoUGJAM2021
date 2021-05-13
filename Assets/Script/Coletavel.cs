using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class Coletavel : MonoBehaviour
{
    public bool isCollected = false;

    public Slider barraComida;
    public Slider barraLixo;

    //public PostProcessAttribute attribute;
    //public ColorGrading _Saturarion;


    private void Start()
    {
        //_Saturarion = ScriptableObject.CreateInstance<ColorGrading>();
    }

    public bool Collect()
    {
        if (isCollected)
        {

            return false;
        }

        
        isCollected = true;
        Destroy(gameObject);
        barraComida.value += 10;
        barraLixo.value += 5;
        //_Saturarion.saturation.value -= 10;
        

        return true;

    }
}
