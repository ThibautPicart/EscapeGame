﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using System;
using System.IO;


public class Register : MonoBehaviour
{

    public GameObject username;
    public GameObject email;
    public GameObject password;
    public GameObject confPassword;
    private string Username;
    private string Email;
    private string Password;
    private string ConfPassword;
    private string form;
    private bool EmailValid;
    private string[] Characters ={"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                                  "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                                    "0","1","2","3","4","5","6","7","8","9","-","_"};

    //pour les popups
    public GameObject UserNameTakenPopUp;
    public GameObject UsernameFieldEmptyPopUp;
    public GameObject EmailIncorrectPopUp;
    public GameObject EmailFeildEmptyPopUp;
    
    public GameObject PasswordTooShortPopUp;
    public GameObject PasswordFieldEmptyPopUp;
    public GameObject PasswordDontMatchPopUp;
    public GameObject ConfPasswordFieldEmptyPopUp;
    public GameObject RegistrationCompletedPopUp;

    void Start()
    {
        if(!Directory.Exists(Application.persistentDataPath + @"\enregistrementProfils\")) //
        {
            Directory.CreateDirectory(Application.persistentDataPath + @"\enregistrementProfils\");
        }
    }

    public void RegisterButton()
    {

        bool UN = false;//username
        bool EM = false;
        bool PW = false;
        bool CPW = false;


        

        //@"C:\Users\ASUS\Documents\GitHub\EscapeGame\EscapeGameV4\enregistrementProfils\" + Username + ".txt"

        if (Username != "")//si username n'est pas vide
        {
            if (!System.IO.File.Exists(Application.persistentDataPath + @"\enregistrementProfils\" + Username + ".txt"))//si le fichier existe
            {

                UN = true;
            }

            else
            {
                Debug.LogWarning("Username Taken");//le code continue quand meme avec warning
                UserNameTakenPopUp.SetActive(true);

            }
       
        }

        else
        {
            Debug.LogWarning("Username field empty");
            UsernameFieldEmptyPopUp.SetActive(true);
        }

        //on vérifie la validité de l'email

        if(Email != "")
        {
            EmailValidation();
            if (EmailValid)//test si l'email est valide
            {
                if (Email.Contains("@"))
                {
                    if (Email.Contains("."))
                    {
                        EM = true;
                    }
                    else
                    {
                        Debug.LogWarning("4-email is Incorrect");
                        EmailIncorrectPopUp.SetActive(true);
                    }
                }

                else
                {
                    Debug.LogWarning("3-email is Incorrect");
                    EmailIncorrectPopUp.SetActive(true);
                }
            }
            else
            {
                Debug.LogWarning("2-email is Incorrect");
                EmailIncorrectPopUp.SetActive(true);
            }
        }
        else
        {
            Debug.LogWarning("1-Email field empty");
            EmailFeildEmptyPopUp.SetActive(true);
        }

        //on vérifie la validité du mot de passe

        if (Password != "")
        {
            if (Password.Length > 5)
            {
                PW = true;
            }
            else
            {
                Debug.LogWarning("password must be at least 6 characters long");
                PasswordTooShortPopUp.SetActive(true);
            }
        }
        else
        {
            Debug.LogWarning("password field empty");
            PasswordFieldEmptyPopUp.SetActive(true);
        }

        //vérifion si la confirmation du MDP est cohérente

        if(ConfPassword != "")
        {
            if (ConfPassword == Password)
            {
                CPW = true;
            }
            else
            {
                Debug.LogWarning("Passwords don't match");
                PasswordDontMatchPopUp.SetActive(true);
            }
        }
        else
        {
            Debug.LogWarning("Confirm password feild empty");
            ConfPasswordFieldEmptyPopUp.SetActive(true);
        }

        if(UN==true && EM==true && PW == true && CPW == true)
        {
            bool Clear = true;
            int i = 1;
            foreach(char c in Password)//pour chiffrer les mots de passes
            {
                if (Clear)
                {
                    Password ="";
                    Clear = false;
                }

                i++;
                char Encrypted = (char)(c * i);
                Password += Encrypted.ToString();
            }
            form = (Username + "\n" + Email + "\n" + Password);
            System.IO.File.WriteAllText(Application.persistentDataPath + @"\enregistrementProfils\" + Username + ".txt", form );
            //une fois le profil enregister on vide les formes pour pouvoir inscrire une nouvelle personne
            username.GetComponent<InputField>().text="";
            email.GetComponent<InputField>().text="";
            password.GetComponent<InputField>().text="";
            confPassword.GetComponent<InputField>().text="";
            print("registration complete");
            RegistrationCompletedPopUp.SetActive(true);
        }


    }
    
    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Tab))&& Username != "")//si on appui sur tab ou entrée : le entrée est à corriger!
        {
            if (username.GetComponent<InputField>().isFocused)//isFocused signifie qu'on est entrain de remplir ce champs

            {
                email.GetComponent<InputField>().Select();//select permet de passer au rectangle suivant
            }

            if (email.GetComponent<InputField>().isFocused)//isFocused signifie qu'on est entrain de remplir ce champs

            {
                password.GetComponent<InputField>().Select();//select permet de passer au rectangle suivant
            }

            if (password.GetComponent<InputField>().isFocused)//isFocused signifie qu'on est entrain de remplir ce champs

            {
                confPassword.GetComponent<InputField>().Select();//select permet de passer au rectangle suivant
            }

            //une fois qu'on a rempli toutes les formes
            if (Input.GetKeyDown(KeyCode.Return)&& Password != "" && Email != "" && Password != "" && ConfPassword != "")//"" signifie Null
            {
              
                RegisterButton();//appelle de la fonction registerButton
                
            }

        }

        Username = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Password =password.GetComponent<InputField>().text;
        ConfPassword = confPassword.GetComponent<InputField>().text;
    }
    void EmailValidation()
    {
        bool SW = false;
        bool EW = false;
        for(int i = 0; i < Characters.Length; i++)
        {
            if (Email.StartsWith(Characters[i]))
            {
                SW = true;
            }
        }
        for (int i = 0; i < Characters.Length; i++)
        {
            if (Email.EndsWith(Characters[i]))
            {
                EW = true;
            }
            if(SW== true && EW == true)
            {
                EmailValid = true;
            }
        }
    }
}
