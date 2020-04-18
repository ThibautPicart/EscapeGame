using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigme : MonoBehaviour
{
    //liste des images pour y glisser les images gameObject
    public GameObject zero;
    public GameObject un;
    public GameObject deux;
    public GameObject trois;
    public GameObject quatre;
    public GameObject cinq;
    public GameObject six;
    public GameObject sept;
    public GameObject huit;
    public GameObject neuf;

















    //forcement au moment où on lit ce script enigme, on est déjà passé par le menu et il y a donc un niveau de difficulté de selectionné
    private static readonly string levelDifficulty = "levelDifficulty";
    private string levelString;

    // Start is called before the first frame update
    void Start()
    {
        //déclaration des suites faciles
        List<string> SuiteFacile1 = new List<string>() { "1", "2", "3", "4", "5", "6", "7" };
        List<string> SuiteFacile2 = new List<string>() { "2", "4", "6", "8", "10", "12", "14" };

        // déclaration des suite intermédiaires
        List<string> SuiteIntermediaire1 = new List<string>() { "10", "20", "30", "40", "50", "60", "70" };
        List<string> SuiteIntermediaire2 = new List<string>() { "20", "40", "60", "80", "100", "120", "140}" };
        //déclaration des suite compliquées
        List<string> SuiteDifficile1 = new List<string>() { "10000", "20000", "30000", "40000", "50000", "60000", "70000" };
        List<string> SuiteDifficile2 = new List<string>() { "20000", "40000", "60000", "80000", "100000", "120000", "140000}" };

        //on fait les listes composées de toutes les listes
        List<List<string>> SuitesFaciles = new List<List<string>>() { SuiteFacile1, SuiteFacile2 };
        List<List<string>> SuitesIntermediaires = new List<List<string>>() { SuiteIntermediaire1, SuiteIntermediaire2 };
        List<List<string>> SuitesDifficiles = new List<List<string>>() { SuiteDifficile1, SuiteDifficile2 };



        int NombreSuitesFaciles = SuitesFaciles.Count;
        int NombreSuitesIntermediaires = SuitesIntermediaires.Count;
        int NombreSuitesDifficiles = SuitesDifficiles.Count;
       
        levelString = PlayerPrefs.GetString(levelDifficulty);
        print(levelString);


        
        if (levelString== "Easy")
        {
            int randomInt = Random.Range(0, NombreSuitesFaciles); //Génère un entier compris entre 0 et le nombre d'élément de la liste
            print("le nombre tiré au hasard est :" + randomInt);
            //on va donc selectionner la bonne suite maintenant
            List<string> EasyRandom = SuitesFaciles[randomInt];
            //j'écris la suite selectionnée dans la console
            print("la suite tirée au hasard est :"+EasyRandom[0]+","+ EasyRandom[1] + ","+EasyRandom[2] +","+ EasyRandom[3] +","+ EasyRandom[4] +","+ EasyRandom[5] +","+ EasyRandom[6] );
            List<string> SuiteChosen = EasyRandom;


            //à partir de maintenant le ode que je veux mettre à l'exterieur des blocs if
            
            string nombre;
            int nombreDeChiffre;
            for (int i = 0; i < SuiteChosen.Count; ++i)
            {
                nombre = SuiteChosen[i];
                //print("le " + (i+1) + " eme nombre de la suite est :" + nombre);
                //maintenant on va séparé le nombre en chiffre si il est composé de plus de 1 chiffre
                nombreDeChiffre = nombre.Length;
                print(nombre + " est composé de " + nombreDeChiffre + " chiffre(s)");

                //on va donc créer une liste composé de chaque chiffre du nombre
                List<char> Nombre = new List<char>();
                for(int j=0;j< nombreDeChiffre; ++j)
                {
                    Nombre.Add(nombre[j]);//la liste Nombre contient donc chaque caractère composant le nombre = chaque chiffe
                    //associer le chiffre à l'image
                    print(nombre[j]);

                    
                }
                
                

            }

        }

        else if(levelString == "Intermediate")
            {
            int randomInt = Random.Range(0, NombreSuitesIntermediaires); //Génère un entier compris entre 0 et le nombre d'élément de la liste
            print("le nombre tiré au hasard est :" + randomInt);
            //on va donc selectionner la bonne suite maintenant
            List<string> IntermediateRandom = SuitesIntermediaires[randomInt];
            //j'écris la suite selectionnée dans la console
            print("la suite tirée au hasard est :" + IntermediateRandom[0] + "," + IntermediateRandom[1] + "," + IntermediateRandom[2] + "," + IntermediateRandom[3] + "," + IntermediateRandom[4] + "," + IntermediateRandom[5] + "," + IntermediateRandom[6]);
            List<string> SuiteChosen = IntermediateRandom;
        }

         else //if(levelString == "Difficult")
        {
            int randomInt = Random.Range(0, NombreSuitesDifficiles); //Génère un entier compris entre 0 et le nombre d'élément de la liste
            print("le nombre tiré au hasard est :" + randomInt);
            //on va donc selectionner la bonne suite maintenant
            List<string> DifficileRandom = SuitesDifficiles[randomInt];
            //j'écris la suite selectionnée dans la console
            print("la suite tirée au hasard est :" + DifficileRandom[0] + "," + DifficileRandom[1] + "," + DifficileRandom[2] + "," + DifficileRandom[3] + "," + DifficileRandom[4] + "," + DifficileRandom[5] + "," + DifficileRandom[6]);
            List<string> SuiteChosen = DifficileRandom;
            
            
        }
        



        //maintenant que nous avons la suite, il convient de faire correspondre à chaque numéro une image

        




    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
