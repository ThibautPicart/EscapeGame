using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;


public class Login : MonoBehaviour
{
    //pour les popup

    public GameObject UserNameInvalidPopUp;
    public GameObject UserFieldEmptyPopUp;
    public GameObject PasswordInvalidPopUp;
    public GameObject PasswordFieldEmptyPopUp;
    //public GameObject LoginSucessfulPopUp;//j'ai mi ce popup dans la selection du niveau de difficultée maintenant


    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
    private string[] Lines;
    private string DecryptedPass;
    public GameObject ProfilMenu;
    public GameObject MainMenu;
    public GameObject userText;
    public GameObject ChoiceLevel;
    private static readonly string ProfilePref = "ProfilePref";
    private static readonly string LoginPref = "LoginPref";

    




    public void LoginButton()
    {
        bool UN = false;//username
        bool PW = false;//password
        if (Username != "")//si il y a quelque chose d'écrit
        {
            if (System.IO.File.Exists((Application.persistentDataPath + @"\enregistrementProfils\" + Username + ".txt")))//on regarde si le profil existe
            {
                UN = true;
                Lines=System.IO.File.ReadAllLines((Application.persistentDataPath + @"\enregistrementProfils\" + Username + ".txt"));//chaque ligne du fichier txt va être séparée
            }
            else
            {
                Debug.LogWarning("Username Invalide");
                UserNameInvalidPopUp.SetActive(true);
            }
        }
        else
        {
            Debug.LogWarning("Username Field Empty");
            UserFieldEmptyPopUp.SetActive(true);
        }



        if (Password != "")
        {
            if (System.IO.File.Exists((Application.persistentDataPath + @"\enregistrementProfils\" + Username + ".txt")))
            {
                
                int i = 1;
                foreach (char c in Lines[2])//lines[2] correspond a la ligne 3 du fichier txt (là où il y a la MDP)
                {
                    i++;
                    char Decrypted = (char)(c / i);//cette fois-ci on divise au lieu de multiplier pour retriuver le MDP
                    DecryptedPass += Decrypted.ToString();
                    
                }
                
                if (Password == DecryptedPass)
                {
                    PW = true;
                    DecryptedPass = ""; 
                }
                else
                {
                    Debug.LogWarning("1) Password is Invalid");
                    PasswordInvalidPopUp.SetActive(true);

                }
            }
            else
            {
                Debug.LogWarning("2) Password is Invalid");
                PasswordInvalidPopUp.SetActive(true);
            }


        }

        else
        {
            Debug.LogWarning("Password Field Empty");
            PasswordFieldEmptyPopUp.SetActive(true);
        }


        if(UN==true && PW == true)
        {
            username.GetComponent<InputField>().text="";//on vide les formes
            password.GetComponent<InputField>().text="";
            print("Login Sucessful");
            //LoginSucessfulPopUp.SetActive(true);
            //MainMenu.SetActive(true);
            ProfilMenu.SetActive(false);
            ChoiceLevel.SetActive(true);
            PlayerPrefs.SetString(ProfilePref, Username);
            PlayerPrefs.SetInt(LoginPref, -1);//-1 implique connecté
            userText.GetComponent<TMPro.TextMeshProUGUI>().text = " Connected profile : " + Username;
            userText.SetActive(true);

        }
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Password != "" && Username != "")
            {
                LoginButton();
            }
        }



        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }

    
}
