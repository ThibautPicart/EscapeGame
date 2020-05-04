using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class equations : MonoBehaviour
{
    //pour faire appel à la fonction du script position des terrains
    public GameObject containerGameObject;
    //playerPref pour envoyer la solution  au script qui fait bouger les terrains
    private static readonly string xSolutionEquation = "xSolutionEquation";
    private static readonly string ySolutionEquation = "ySolutionEquation";

    //les deux ligne d'équation qu'on va écrire sur le mur
    public GameObject equation1;
    public GameObject equation2;

    //pour savoir le niveau de difficulté selectionné
    private static readonly string levelDifficulty = "levelDifficulty";
    private string levelString;

    //equation niveau facile sont des droites f(x)= ax+b : il y en a 2
    //on donne en premier le coefficient directeur a et en seconde position l'ordonée à l'origine b
    //en troisieme et quatrieme position, coefficient directeur et ordonnée à m'origine de la deuxième droite

    private List<string> droite1 = new List<string>() { "1","0","-3","4" };
    private List<string> droite2 = new List<string>() { "3", "6" ,"-7","46"};
    private List<string> solutionDroite1 = new List<string>() { "1", "1" };
    private List<string> solutionDroite2 = new List<string>() { "4", "18" };

    ////intermédiaire cercle
    //les deux premier nombre sont le coefficient directeur et l'ordonée à l'origine de la droite
    //les trois dernier nombre sont : coordonnée du centre du cercle et le rayon du cercle au carré
    private List<string> cercleDroite1 = new List<string>() { "1", "0", "0", "0","9" };
    private List<string> cercleDroite2 = new List<string>() { "2", "1", "1", "2","16" };

    ////difficile elypse
    private List<string> cercleElyspe1 = new List<string>() { "1", "0", "-1", "0" };
    private List<string> cercleElypse2 = new List<string>() { "1", "0", "-2", "0" };



    private List<string> equationChosen;
    private List<string> solutionEquation;
    //public string solutionChosen;

    // Start is called before the first frame update
    void Start()
    {

    //on fait les listes composées de toutes les equations: obligé de mettre ça dans le start !
     List<List<string>> equationsFaciles = new List<List<string>>() { droite1,droite2 };

      //ici , on va devoir mettre les autres solutions, je ne les ai pas encore calculées
     List<List<string>> equationsIntermediaires = new List<List<string>>() { cercleDroite1, cercleDroite2 };
     List<List<string>> equationsDifficiles = new List<List<string>>() { cercleElyspe1, cercleElypse2 };

     //on fait une liste composé des solutions
     List<List<string>> solutionEquationsFaciles = new List<List<string>>() { solutionDroite1, solutionDroite2 };
     List<List<string>> solutionEquationsIntermediaires = new List<List<string>>() { cercleDroite1, cercleDroite2 };
     List<List<string>> solutionEquationsDifficiles = new List<List<string>>() { cercleElyspe1, cercleElypse2 };








        //on récupère le niveau selectionné
        levelString = PlayerPrefs.GetString(levelDifficulty);
        //print(levelstring);

        //niveau facil
        if (levelString == "Easy")
        {
            int randomInt = Random.Range(0, equationsFaciles.Count); //génère un entier compris entre 0 et le nombre d'élément de la liste
            print(randomInt);
            //on va donc selectionner les equations correspondantes maintenant
            equationChosen = equationsFaciles[randomInt];
           
            


            //je selectionne aussi la bonne réponse correpondante afin de l'envoyer danns le script qui fait bouger le sphynx
            solutionEquation = solutionEquationsFaciles[randomInt];

            string xSolution = solutionEquation[0];
            string ySolution = solutionEquation[1];

            //j'envoi la solution au script qui s'occupe de faire boger les terrains => je créer un playerPref
            PlayerPrefs.SetString(xSolutionEquation, xSolution);
            PlayerPrefs.SetString(ySolutionEquation, ySolution);


            //maintenant on va écrire sur le mur les équation correcpondante
            //équation1 ce qu'on ecrit sur le mur
            TMP_Text equation1Text = equation1.GetComponent<TMP_Text>();
            equation1Text.SetText("f(x)= " + equationChosen[0] + "x +" + equationChosen[1]);
            //équation2
            TMP_Text equation2Text = equation2.GetComponent<TMP_Text>();
            equation2Text.SetText("g(x)=" + equationChosen[2] + "x +" + equationChosen[3]);

        }

        else if (levelString == "Intermediate")
        {
            int randomInt = Random.Range(0, equationsIntermediaires.Count); //génère un entier compris entre 0 et le nombre d'élément de la liste

            //on va donc selectionner les equations correspondantes maintenant
            equationChosen = equationsIntermediaires[randomInt];

            //je selectionne aussi la bonne réponse correpondante afin de l'envoyer danns le script qui fait bouger le sphynx
            print("les équation choisies sont :\n" + equationChosen[0] + "x + " + equationChosen[1]);
            //maintenant on va écrire sur le mur les équation correcpondante
            //maintenant on va écrire sur le mur les équation correcpondante
            //équation1 ce qu'on ecrit sur le mur
            TMP_Text equation1Text = equation1.GetComponent<TMP_Text>();
            equation1Text.SetText("f(x)= " + equationChosen[0] + "x +" + equationChosen[1]);//la droite
            //équation2
            TMP_Text equation2Text = equation2.GetComponent<TMP_Text>();
            equation2Text.SetText("(x-" + equationChosen[2] + ")² + (y-" + equationChosen[3] + ")²=" + equationChosen[4]);//le cercle
        }

        else//if(levelstring == "difficult")
        {
            int randomInt = Random.Range(0, equationsDifficiles.Count); //génère un entier compris entre 0 et le nombre d'élément de la liste

            //on va donc selectionner les equations correspondantes maintenant
            equationChosen = equationsDifficiles[randomInt];

            //je selectionne aussi la bonne réponse correpondante afin de l'envoyer danns le script qui fait bouger le sphynx
            print("les équation choisies sont :\n" + equationChosen[0] + "x + " + equationChosen[1]);
            //maintenant on va écrire sur le mur les équation correcpondante
        }

        //pour executer la fonction du script positionTerrainQuiBouge
        containerGameObject.GetComponent<positionTerrainQuiBougent>().MiseEnplaceDuTerrain();
        

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
