﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour   
{

    //private static readonly string ProfilePref = "ProfilePref";
    private static readonly string LoginPref = "LoginPref";
    //private string profileString;
    private int loginInt;
    public GameObject playPopUp;


    public void PlayGame ()
    {
        loginInt = PlayerPrefs.GetInt(LoginPref);

        if (loginInt != 0)//si on est connecté
        {
            //avant de charger la scène, il faut séléctionner la difficulté
            SceneManager.LoadScene(1);
        
        }
        else
        {
            playPopUp.SetActive(true);
        }
    }

    public void QuitGame ()
    {
        Debug.Log("Quit !");
        Application.Quit();
    }

}
