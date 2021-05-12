using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcess : MonoBehaviour
{
    public  PostProcessVolume volume;
    public ColorGrading _Saturarion;


    void Start()
    {
        //volume.profile.TryGetSettings(out _Saturarion);
        //_Saturarion.saturation.value = -100;

        _Saturarion = ScriptableObject.CreateInstance<ColorGrading>();
        _Saturarion.enabled.Override(true);
        _Saturarion.saturation.value = -100;

        //volume = PostProcessManager.instance.QuickVolume(gameObject, -100f, _Saturarion);
    }

    // Update is called once per frame
    void Update()
    {
        _Saturarion.saturation.value = Mathf.Lerp(_Saturarion.saturation.value, 15, .5f * Time.deltaTime);
    }
}
