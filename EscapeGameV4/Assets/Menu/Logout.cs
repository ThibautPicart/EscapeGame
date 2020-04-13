using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logout : MonoBehaviour
{
    private static readonly string ProfilePref = "ProfilePref";
    private static readonly string LoginPref = "LoginPref";
    public GameObject user;

    //pour les popups
    public GameObject wellDisconnectedPopUp;
    public GameObject beingConnectedPopUp;

    public void logout()
    {

        
        if (PlayerPrefs.GetInt(LoginPref) != 0)//si on appui sur logout et qu'on a un compte de connecté
        {
            PlayerPrefs.SetString(ProfilePref, "");
            user.GetComponent<TMPro.TextMeshProUGUI>().text = " Connected profile : " + "";
            PlayerPrefs.SetInt(LoginPref, 0);
            wellDisconnectedPopUp.SetActive(true);
        }
        else//popup pour dire qu'on a bien été déconnecter
        {
            beingConnectedPopUp.SetActive(true);
        }
        
        

    
    }
}
