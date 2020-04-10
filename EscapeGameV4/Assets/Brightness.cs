using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{

    public float GammaCorrection=0.5f;

    public Slider luminosity;

    void Update()
    {

        RenderSettings.ambientLight = new Color(GammaCorrection, GammaCorrection, GammaCorrection, 1.0f);

    }

    void OnGUI()
    {

        GammaCorrection = luminosity.value;
        print(GammaCorrection);
    }

}
