﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;


public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
    private string[] Lines;
    private string DecryptedPass;

    public void LoginButton()
    {
        bool UN = false;//username
        bool PW = false;//password
        if (Username != "")//si il y a quelque chose d'écrit
        {
            if (System.IO.File.Exists(@"C:\Users\ASUS\Documents\GitHub\EscapeGame\EscapeGameV4\enregistrementProfils\" + Username + ".txt"))//on regarde si le profil existe
            {
                UN = true;
                Lines=System.IO.File.ReadAllLines(@"C:\Users\ASUS\Documents\GitHub\EscapeGame\EscapeGameV4\enregistrementProfils\" + Username + ".txt");//chaque ligne du fichier txt va être séparée
            }
            else
            {
                Debug.LogWarning("Username Invalide");
            }
        }
        else
        {
            Debug.LogWarning("Username Field Empty");
        }



        if (Password != "")
        {
            if (System.IO.File.Exists(@"C:\Users\ASUS\Documents\GitHub\EscapeGame\EscapeGameV4\enregistrementProfils\" + Username + ".txt"))
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
                }
                else
                {
                    Debug.LogWarning("Password is Invalid");
                }
            }
            else
            {
                Debug.LogWarning("Password is Invalid");
            }


        }
        else
        {
            Debug.LogWarning("Password Field Empty");
        }
        if(UN==true && PW == true)
        {
            username.GetComponent<InputField>().text="";//on vide les formes
            password.GetComponent<InputField>().text="";
            print("Login Sucessful");
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
            if (Password != "" && Password != "")
            {
                LoginButton();
            }
        }



        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }
}
