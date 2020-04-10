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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RegisterButton()
    {
        print("Registration Sucessful");
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
}
