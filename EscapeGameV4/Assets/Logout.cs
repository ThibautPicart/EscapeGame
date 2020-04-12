using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logout : MonoBehaviour
{
    private static readonly string ProfilePref = "ProfilePref";
    private static readonly string LoginPref = "LoginPref";
    public GameObject user;

    public void logout()
    {
        PlayerPrefs.SetString(ProfilePref, "");
        user.GetComponent<TMPro.TextMeshProUGUI>().text = " Connected profile : " + "";
        PlayerPrefs.SetInt(LoginPref, 0);
    
    }
}
