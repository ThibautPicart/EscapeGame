using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//class Brightness
public class Brightness : MonoBehaviour
{

    public float GammaCorrection =0.5f;

    //enregistrement des donnée
    private static readonly string FirstPlayPref2 = "FirstPlayPref2";
    private int firstPlayInt;
    private static readonly string LuminosityPref = "LuminosityPref";

    public Slider luminosity;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlayPref2);

        if (firstPlayInt == 0)
        {
           // print("test");
            luminosity.value = GammaCorrection;
            PlayerPrefs.SetFloat(LuminosityPref, GammaCorrection);
            PlayerPrefs.SetInt(FirstPlayPref2, -1);
        }
        else
        {
            //print("else");
            GammaCorrection = PlayerPrefs.GetFloat(LuminosityPref);
            RenderSettings.ambientLight = new Color(GammaCorrection, GammaCorrection, GammaCorrection, 1.0f);
            luminosity.value = GammaCorrection;
        }
    }






        
        

    public void setLuminosity(float sliderValue)
    {
            
       RenderSettings.ambientLight = new Color(sliderValue, sliderValue, sliderValue, 1.0f);
            
    }




    // Fonction qui sauvegarde dans playerPrefs les valeurs des sliders
    public void SaveLuminositySettings()
    {
        PlayerPrefs.SetFloat(LuminosityPref, luminosity.value);
        print("SaveLuminositySettings appelé");
        print(PlayerPrefs.GetFloat(LuminosityPref));
    }


    // Quand on quitte l'application, on appelle la fonction qui sauvegarde les données du slider
    void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            SaveLuminositySettings();
        }
    }

}

