using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actualLevel : MonoBehaviour
{

    private static readonly string levelDifficulty = "levelDifficulty";
    private static readonly string LoginPref = "LoginPref";
    private int loginInt;
    private string levelString;
    public GameObject level;



    // Start is called before the first frame update
    void Start()
    {
        
        loginInt = PlayerPrefs.GetInt(LoginPref);
        if (loginInt != 0)//si il y a une personne de connecté
        {
            levelString = PlayerPrefs.GetString(levelDifficulty);
            level.GetComponent<TMPro.TextMeshProUGUI>().text = " Level selected : " + levelString;
            level.SetActive(true);

        }
        else
        {
            level.SetActive(false);
        }
    }
}
