using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setLuminosity : MonoBehaviour
{


    float rgbValue = 0.5f;







//    float rgbValue;
//    public Slider luminositySlider;

//    //pour enregistrer les modifications
//    private static readonly string FirstPlayPref = "FirstPlayPref";// si il n'a pas de valeur, il est a 0
//    private static readonly string LuminosityPref = "LuminosityPref";
//    private int firstPlayInt;

//    // Start is called before the first frame update
//    void Start()
//    {
        
//        RenderSettings.ambientLight = new Color(0,0,0,1);
//        firstPlayInt = PlayerPrefs.GetInt(FirstPlayPref);

//        if (firstPlayInt == 0)// la première fois on passe par ici
//        {
//            rgbValue = 0.5f;

//            print("je passe pour la premiere fois dans set luminosity ");
//            luminositySlider.value = rgbValue;
//            PlayerPrefs.SetFloat(LuminosityPref, rgbValue);
//            PlayerPrefs.SetInt(FirstPlayPref, -1);


//        }
//        //on replace le curseul comme il était avant si ce n'est pas la première fois qu'on a modifié la luminosité
//        else
//        {


//            rgbValue = PlayerPrefs.GetFloat(LuminosityPref);
//            print("je passe et la valeur de rgbvalue =" + rgbValue);
//            RenderSettings.ambientLight = new Color(rgbValue, rgbValue, rgbValue, 1);
//            luminositySlider.value = rgbValue;

//        }
//    }

//    public void setLevel(float sliderValue)
//    {
//        //RenderSettings.ambientLight = new Color(sliderValue, sliderValue, sliderValue, 1);
//        RenderSettings.ambientLight = Color.blue;
//    }







//    // Fonction qui sauvegarde dans playerPrefs les valeurs des sliders
//    public void SaveSoundSettings()
//    {
//        PlayerPrefs.SetFloat(LuminosityPref, luminositySlider.value);         
//        print("luminositySlider.value =");
//        print(luminositySlider.value);
//    }


//    // Quand on quitte l'application, on appelle la fonction qui sauvegarde les données du slider
//    void OnApplicationFocus(bool inFocus)
//    {
//        if (!inFocus)
//        {
//            SaveSoundSettings();
//        }
//    }
    
}
