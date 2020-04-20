using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class actualProfile : MonoBehaviour
{

    private static readonly string ProfilePref = "ProfilePref";
    private static readonly string LoginPref = "LoginPref";
    private string profileString;
    private int loginInt;
    public GameObject user;

    // Start is called before the first frame update
    void Start()
    {
        loginInt = PlayerPrefs.GetInt(LoginPref);

        if (loginInt != 0)//si il y a une personne de connecté
        {
            profileString = PlayerPrefs.GetString(ProfilePref);
            user.GetComponent<TMPro.TextMeshProUGUI>().text = " Connected profile : " + profileString;
            user.SetActive(true);

        }
        else
        {
            user.SetActive(false);
        }
    }
}
