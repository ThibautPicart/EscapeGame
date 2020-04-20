using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setSettings : MonoBehaviour
{
    public float GammaCorrection;
    // Start is called before the first frame update
    void Start()
    {
        
        GammaCorrection = PlayerPrefs.GetFloat("LuminosityPref");
        RenderSettings.ambientLight = new Color(GammaCorrection, GammaCorrection, GammaCorrection, 1.0f);
    }

    
}
