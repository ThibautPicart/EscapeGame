using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setSettings : MonoBehaviour
{
    //pour savoir si c'est la premiere fois qu'on entre dans le jeu
    int firstComeInt;//de base il est initialisé à 0
    //private static readonly string firstComepref = "firstComePref";

    //enregistrer la position du personnage 
    private static readonly string xPersonnage = "xPersonnage";
    private static readonly string yPersonnage = "yPersonnage";
    private static readonly string zPersonnage = "zPersonnage";


    public GameObject personnage;





    public float GammaCorrection;
    // Start is called before the first frame update
    void Start()
    {
        firstComeInt = PlayerPrefs.GetInt("firstComePref");
        firstComeInt = 0;
        if (firstComeInt == 0)
        {
            print("if");
            PlayerPrefs.SetInt("firstComePref", 1);
            personnage.transform.localPosition = new Vector3(28f, 7f, 10f);
        }


        else
        {
            //on affecte les valeurs de positions récupérées à l'aide des playersPrefs
            print("chiffre");
            print(PlayerPrefs.GetFloat(xPersonnage));
            personnage.transform.localPosition = new Vector3(PlayerPrefs.GetFloat(xPersonnage), PlayerPrefs.GetFloat(yPersonnage), PlayerPrefs.GetFloat(zPersonnage));
        
        }






        //Pour récupérer la valeu de luminosité selectionné dans les réglages du menu démarrer
            GammaCorrection = PlayerPrefs.GetFloat("LuminosityPref");
            RenderSettings.ambientLight = new Color(GammaCorrection, GammaCorrection, GammaCorrection, 1.0f);
        
    }

  
}
