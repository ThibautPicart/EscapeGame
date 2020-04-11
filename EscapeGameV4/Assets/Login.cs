//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using System;
//using System.Text.RegularExpressions;


//public class Login : MonoBehaviour
//{
//    public GameObject username;
//    public GameObject password;
//    private string Username;
//    private string Password;

//    public void LoginButton()
//    {
//        bool UN = false;//username
//        bool PW = false;//password
//        if (Username != "")//si il y a quelque chose d'écrit
//        {
//            if (System.IO.File.Exists(@"C:\Users\ASUS\Documents\GitHub\EscapeGame\EscapeGameV4\enregistrementProfils\" + Username + ".txt"))//on regarde si le profil existe
//            {
//                UN = true;
//            }
//        }
//    }

    

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Tab))
//        {
//            if (username.GetComponent<InputField>().isFocused)
//            {
//                password.GetComponent<InputField>().Select();
//            }
//        }

//        if (Input.GetKeyDown(KeyCode.Return))
//        {
//            if (Password !="" && Passord!="" )
//            {
//                LoginButton();
//            }
//        }



//        Username = username.GetComponent<InputField>().text;
//        Password = password.GetComponent<InputField>().text;
//    }
//}
