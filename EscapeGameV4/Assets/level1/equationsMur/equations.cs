using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class equations : MonoBehaviour
{
    //les deux ligne d'équation qu'on va écrire sur le mur
    public GameObject equation1;
    public GameObject equation2;

    //pour savoir le niveau de difficulté selectionné
    private static readonly string levelDifficulty = "levelDifficulty";
    private string levelString;

    //equation niveau facile sont des droites f(x)= ax+b : il y en a 2
    //on donne en premier le coefficient directeur a et en seconde position l'ordonée à l'origine b
    //en troisieme et quatrieme position, coefficient directeur et ordonnée à m'origine de la deuxième droite

    List<string> droite1 = new List<string>() { "1","0","-1","0" };
    List<string> droite2 = new List<string>() { "1", "0" ,"-2","0"};


    //intermédiaire cercle
    List<string> cercleDroite1 = new List<string>() { "1", "0", "-1", "0" };
    List<string> cercleDroite2 = new List<string>() { "1", "0", "-2", "0" };

    //difficile elypse
    List<string> cercleElyspe1 = new List<string>() { "1", "0", "-1", "0" };
    List<string> cercleElypse2 = new List<string>() { "1", "0", "-2", "0" };



    //on fait les listes composées de toutes les equations
    List<List<string>> equationsFaciles = new List<List<string>>() { droite1, droite2 };
    List<List<string>> equationsIntermediaires = new List<List<string>>() { cercleDroite1, cercleDroite2 };
    List<List<string>> equationsDifficiles = new List<List<string>>() { cercleElyspe1, cercleElyspe2 };

    List<string> equationChosen;
 
    //public string solutionChosen;

    // Start is called before the first frame update
    void Start()
    {
        //équation1 ce qu'on ecrit sur le mur
        TMP_Text equation1Text = equation1.GetComponent<TMP_Text>();
        equation1Text.SetText("f(x)= ");
        //équation2
        TMP_Text equation2Text = equation2.GetComponent<TMP_Text>();
        equation2Text.SetText("g(x)=");


        ////on récupère le niveau selectionné
        //levelString = PlayerPrefs.GetString(levelDifficulty);
        //print(levelString);

        ////niveau facil
        //if (levelString == "Easy")
        //{
        //    int randomInt = Random.Range(0, equationsFaciles.Count); //Génère un entier compris entre 0 et le nombre d'élément de la liste

        //    //on va donc selectionner les equations maintenant
        //    equationChosen = equationsFaciles[randomInt];

           //je selectionne aussi la bonne réponse correpondante afin de l'envoyer danns le script qui fait bouger le sphynx
          
           //S SolutionChosen = Solution;
        //}

        //else if (levelString == "intermediate")
        //{
        //    print("jbnk");
        //}

        //else//if(levelString == "Difficult")
        //{
        //    print("jbnk");
        //}


    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
