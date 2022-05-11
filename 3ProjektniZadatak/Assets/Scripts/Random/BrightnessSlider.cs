using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessSlider : MonoBehaviour
{
    public Slider brightnessSlider; // slider
    public Light sceneLight; // svijetlo

    void Start()
    {

    }

    void Update()
    {
        sceneLight.intensity = brightnessSlider.value; // velicinu value-a slidera pridruzivamo jacini svijetla
    }

}
