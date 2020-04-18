using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDifficulty : MonoBehaviour
{

    private static readonly string levelDifficulty = "levelDifficulty";
    public GameObject LoginSucessfulPopUp;

    public void EasyLevelDifficulty()
    {
        PlayerPrefs.SetString(levelDifficulty, "Easy");
        LoginSucessfulPopUp.SetActive(true);
        print("je passe dans le easy");
    }

    public void IntermediateLevelDifficulty()
    {
        PlayerPrefs.SetString(levelDifficulty, "Intermediate");
        LoginSucessfulPopUp.SetActive(true);
    }

    public void HardLevelDifficulty()
    {
        PlayerPrefs.SetString(levelDifficulty, "Difficult");
        LoginSucessfulPopUp.SetActive(true);
    }
}
