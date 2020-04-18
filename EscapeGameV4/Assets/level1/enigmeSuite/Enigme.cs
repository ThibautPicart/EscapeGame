using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigme : MonoBehaviour
{
    //forcement au moment où on lit ce script enigme, on est déjà passé par le menu et il y a donc un niveau de difficulté de selectionné
    private static readonly string levelDifficulty = "levelDifficulty";

    // Start is called before the first frame update
    void Start()
    {
        //déclaration des suites faciles
        List<string> SuiteFacile1 = new List<string>() { "1", "2", "3", "4", "5", "6", "7" };
        List<string> SuiteFacile2 = new List<string>() { "2", "4", "6", "8", "10", "12", "14}" };

        // déclaration des suite intermédiaires
        List<string> SuiteIntermediaire1 = new List<string>() { "1", "2", "3", "4", "5", "6", "7" };
        List<string> SuiteIntermediaire2 = new List<string>() { "2", "4", "6", "8", "10", "12", "14}" };
        //déclaration des suite compliquées
        List<string> SuiteDifficile1 = new List<string>() { "1", "2", "3", "4", "5", "6", "7" };
        List<string> SuiteDifficile2 = new List<string>() { "2", "4", "6", "8", "10", "12", "14}" };

        //on fait les listes composées de toutes les listes
        List<List<string>> SuitesFaciles = new List<List<string>>() { SuiteFacile1, SuiteFacile2 };
        List<List<string>> SuitesIntermediaires = new List<List<string>>() { SuiteIntermediaire1, SuiteIntermediaire2 };
        List<List<string>> SuitesDifficiles = new List<List<string>>() { SuiteDifficile1, SuiteDifficile2 };



        int NombreSuitesFaciles = SuitesFaciles.Count;
     
        
        int randomInt = Random.Range(0,NombreSuitesFaciles); //Génère un entier compris entre 0 et 9
        print("le nombre tiré au hasard est :" + randomInt);

        //pn va donc prendre la suite au hasard


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
