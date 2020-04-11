using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using System;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RegisterButton()
    {

        bool UN = false;//username
        bool EM = false;
        bool PW = false;
        bool CPW = false;


        print("Registration Sucessful");


        if (Username != "")//si username n'est pas vide
        {
            if (!System.IO.File.Exists(@"C:\Users\ASUS\Documents\GitHub\EscapeGame\EscapeGameV4\enregistrementProfils\etapeSup" + Username + ".txt"))//si le fichier existe
            {

                UN = true;
            }

            else
            {
                Debug.LogWarning("Username Taken");//le code continue quand meme avec warning

            }
       
        }

        else
        {
            Debug.LogWarning("Username field empty");
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
                    }
                }

                else
                {
                    Debug.LogWarning("3-email is Incorrect");
                }
            }
            else
            {
                Debug.LogWarning("2-email is Incorrect");
            }
        }
        else
        {
            Debug.LogWarning("1-Email field empty");
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
            }
        }
        else
        {
            Debug.LogWarning("password field empty");
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
            }
        }
        else
        {
            Debug.LogWarning("Confirm password feild empty");
        }

        if(UN==true && EM==true && PW == true && CPW == true)//voir 24m30
        {
            bool Clear = true;
            int i = 1;
            foreach(char c in Password)
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
            System.IO.File.WriteAllText(@"C:\Users\ASUS\Documents\GitHub\EscapeGame\EscapeGameV4\enregistrementProfils\etapeSup" + Username + ".txt",form );
            //une fois le profil enregister on vide les formes pour pouvoir inscrire une nouvelle personne
            username.GetComponent<InputField>().text="";
            email.GetComponent<InputField>().text="";
            password.GetComponent<InputField>().text="";
            confPassword.GetComponent<InputField>().text="";
            print("registrartion complete");
        }


    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Tab) )//si on appui sur tab ou entrée : le entrée est à corriger!
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
