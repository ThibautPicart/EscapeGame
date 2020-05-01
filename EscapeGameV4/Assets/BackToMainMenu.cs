using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMainMenu : MonoBehaviour
{
    



    //afin de stocker les coordonees du personnage au moment ou l'on quitte l'ecran de jeu
    private static readonly string xPersonnage = "xPersonnage";
    private static readonly string yPersonnage = "yPersonnage";
    private static readonly string zPersonnage = "zPersonnage";
    public GameObject personnage;

    //



    void GoBackToMainMenu()
    {
        PlayerPrefs.SetFloat(xPersonnage, personnage.transform.localPosition.x);
        print(personnage.transform.localPosition.x);
        PlayerPrefs.SetFloat(yPersonnage, personnage.transform.localPosition.y);
        PlayerPrefs.SetFloat(zPersonnage, personnage.transform.localPosition.z);
        SceneManager.LoadScene(0);


    }
    
}
