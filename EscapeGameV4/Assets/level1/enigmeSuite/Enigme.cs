using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigme : MonoBehaviour
{
    //liste des images pour y glisser les images gameObject
    //pour Canevas0
    public Image zeroC0;//pour dire l  du canevas0
    public Image unC0;
    public Image deuxC0;
    public Image troisC0;
    public Image quatreC0;
    public Image cinqC0;
    public Image sixC0;
    public Image septC0;
    public Image huitC0;
    public Image neufC0;
    public Image interrogationC0;
    //pour Canevas1
    public Image zeroC1;
    public Image unC1;
    public Image deuxC1;
    public Image troisC1;
    public Image quatreC1;
    public Image cinqC1;
    public Image sixC1;
    public Image septC1;
    public Image huitC1;
    public Image neufC1;
    public Image interrogationC1;
    //pour Canevas2
    public Image zeroC2;
    public Image unC2;
    public Image deuxC2;
    public Image troisC2;
    public Image quatreC2;
    public Image cinqC2;
    public Image sixC2;
    public Image septC2;
    public Image huitC2;
    public Image neufC2;
    public Image interrogationC2;
    //pour Canevas3
    public Image zeroC3;
    public Image unC3;
    public Image deuxC3;
    public Image troisC3;
    public Image quatreC3;
    public Image cinqC3;
    public Image sixC3;
    public Image septC3;
    public Image huitC3;
    public Image neufC3;
    public Image interrogationC3;
    //pour Canevas4
    public Image zeroC4;
    public Image unC4;
    public Image deuxC4;
    public Image troisC4;
    public Image quatreC4;
    public Image cinqC4;
    public Image sixC4;
    public Image septC4;
    public Image huitC4;
    public Image neufC4;
    public Image interrogationC4;
    //pour Canevas5
    public Image zeroC5;
    public Image unC5;
    public Image deuxC5;
    public Image troisC5;
    public Image quatreC5;
    public Image cinqC5;
    public Image sixC5;
    public Image septC5;
    public Image huitC5;
    public Image neufC5;
    public Image interrogationC5;
    //pour Canevas6
    public Image zeroC6;
    public Image unC6;
    public Image deuxC6;
    public Image troisC6;
    public Image quatreC6;
    public Image cinqC6;
    public Image sixC6;
    public Image septC6;
    public Image huitC6;
    public Image neufC6;
    public Image interrogationC6;
    //pour Canevas7
    public Image zeroC7;
    public Image unC7;
    public Image deuxC7;
    public Image troisC7;
    public Image quatreC7;
    public Image cinqC7;
    public Image sixC7;
    public Image septC7;
    public Image huitC7;
    public Image neufC7;
    public Image interrogationC7;
    //pour Canevas8
    public Image zeroC8;
    public Image unC8;
    public Image deuxC8;
    public Image troisC8;
    public Image quatreC8;
    public Image cinqC8;
    public Image sixC8;
    public Image septC8;
    public Image huitC8;
    public Image neufC8;
    public Image interrogationC8;
    //pour Canevas9
    public Image zeroC9;
    public Image unC9;
    public Image deuxC9;
    public Image troisC9;
    public Image quatreC9;
    public Image cinqC9;
    public Image sixC9;
    public Image septC9;
    public Image huitC9;
    public Image neufC9;
    public Image interrogationC9;
    //pour Canevas10
    public Image zeroC10;
    public Image unC10;
    public Image deuxC10;
    public Image troisC10;
    public Image quatreC10;
    public Image cinqC10;
    public Image sixC10;
    public Image septC10;
    public Image huitC10;
    public Image neufC10;
    public Image interrogationC10;
    //pour Canevas11
    public Image zeroC11;
    public Image unC11;
    public Image deuxC11;
    public Image troisC11;
    public Image quatreC11;
    public Image cinqC11;
    public Image sixC11;
    public Image septC11;
    public Image huitC11;
    public Image neufC11;
    public Image interrogationC11;
    //pour Canevas12
    public Image zeroC12;
    public Image unC12;
    public Image deuxC12;
    public Image troisC12;
    public Image quatreC12;
    public Image cinqC12;
    public Image sixC12;
    public Image septC12;
    public Image huitC12;
    public Image neufC12;
    public Image interrogationC12;
    //pour Canevas13
    public Image zeroC13;
    public Image unC13;
    public Image deuxC13;
    public Image troisC13;
    public Image quatreC13;
    public Image cinqC13;
    public Image sixC13;
    public Image septC13;
    public Image huitC13;
    public Image neufC13;
    public Image interrogationC13;
    //pour Canevas14
    public Image zeroC14;
    public Image unC14;
    public Image deuxC14;
    public Image troisC14;
    public Image quatreC14;
    public Image cinqC14;
    public Image sixC14;
    public Image septC14;
    public Image huitC14;
    public Image neufC14;
    public Image interrogationC14;
    //pour Canevas15
    public Image zeroC15;
    public Image unC15;
    public Image deuxC15;
    public Image troisC15;
    public Image quatreC15;
    public Image cinqC15;
    public Image sixC15;
    public Image septC15;
    public Image huitC15;
    public Image neufC15;
    public Image interrogationC15;

    //liste des canevas correpondant aux images on en met 2 par lier pour l'instant
    public GameObject caneva0;
    public GameObject caneva1;
    public GameObject caneva2;
    public GameObject caneva3;
    public GameObject caneva4;
    public GameObject caneva5;
    public GameObject caneva6;
    public GameObject caneva7;
    public GameObject caneva8;
    public GameObject caneva9;
    public GameObject caneva10;
    public GameObject caneva11;
    public GameObject caneva12;
    public GameObject caneva13;
    public GameObject caneva14;
    public GameObject caneva15;

    //playerPref pour envoyer la solution de la suite au script qui fait bouger le sphynx
    private static readonly string solutionSuite = "solutionSuite";


    //forcement au moment où on lit ce script enigme, on est déjà passé par le menu et il y a donc un niveau de difficulté de selectionné
    private static readonly string levelDifficulty = "levelDifficulty";
    private string levelString;

    // Start is called before the first frame update
    void Start()
    {
        //déclaration des suites faciles
        List<string> SuiteFacile1 = new List<string>() { "00", "00", "00", "00", "00", "00", "??","00" };
        List<string> SuiteFacile2 = new List<string>() { "2", "4", "6", "8", "10", "12", "14","??" };

        //déclaration des solutions des suites faciles
        string SolutionSuiteFacile1 = "16";
        string SolutionSuiteFacile2 = "16";

        // déclaration des suite intermédiaires
        List<string> SuiteIntermediaire1 = new List<string>() { "10", "20", "30", "40", "50", "60", "70","??" };
        List<string> SuiteIntermediaire2 = new List<string>() { "20", "40", "60", "80", "100", "120", "140","??" };

        //déclaration des solutions des suites intermediaires
        string SolutionSuiteIntermediaire1 = "00";
        string SolutionSuiteIntermediaire2 = "16";

        //déclaration des suite compliquées
        List<string> SuiteDifficile1 = new List<string>() { "0", "1", "10", "11", "??", "5", "6","7" };
        List<string> SuiteDifficile2 = new List<string>() { "20", "4", "60", "80", "10", "10", "14","??"};

        //déclaration des solutions des suites compliquées
        string SolutionSuiteDifficile1 = "00";
        string SolutionSuiteDifficile2 = "16";

        //on fait les listes composées de toutes les listes
        List<List<string>> SuitesFaciles = new List<List<string>>() { SuiteFacile1, SuiteFacile2 };
        List<List<string>> SuitesIntermediaires = new List<List<string>>() { SuiteIntermediaire1, SuiteIntermediaire2 };
        List<List<string>> SuitesDifficiles = new List<List<string>>() { SuiteDifficile1, SuiteDifficile2 };

        //on fait une liste composée de toutes les solution
        List<string> SolutionsFaciles = new List<string>() { SolutionSuiteFacile1, SolutionSuiteFacile2 };
        List<string> SolutionsIntermediaires = new List<string>() { SolutionSuiteIntermediaire1, SolutionSuiteIntermediaire2 };
        List<string> SolutionsDifficiles = new List<string>() { SolutionSuiteDifficile1, SolutionSuiteDifficile2 };



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

            //je selectionne aussi la bonne réponse correpondante afin de l'envoyer danns le script qui fait bouger le sphynx
            string Solution = SolutionsFaciles[randomInt];

            //j'écris la suite selectionnée dans la console
            print("la suite tirée au hasard est :"+EasyRandom[0]+","+ EasyRandom[1] + ","+EasyRandom[2] +","+ EasyRandom[3] +","+ EasyRandom[4] +","+ EasyRandom[5] +","+ EasyRandom[6] );
            List<string> SuiteChosen = EasyRandom;
            string SolutionChosen = Solution;


            //à partir de maintenant le code que je veux mettre à l'exterieur des blocs if

            //j'envoi la solution au script du sphynx => je créer un playerPref
            PlayerPrefs.SetString(solutionSuite, SolutionChosen);

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
                                          //print(Nombre[j]);
                    if (Nombre[j] == '?')
                    {
                        //print("on va y arriver");
                        //il est important de poser d'entrer qu'on aura à chaque fois deux images par poteau par exemple on reste sur le poteau 1 c'est à dire
                        //les canvas 0 et 1 tant que j=0 ou j=1 comme il y a 8 poteaux il y a 16 canvas (de 0 à15)


                        //on va donc chercher sur quel canvas on met l'image maintenant
                        if (i == 0)//premier poteau car i va de 0 à 7
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre pour trouver le bon canevas
                            {
                                print("prmier chiffre du nombre");
                                //on va donc mettre un zéro sur le canvas0
                                interrogationC0.enabled = true;

                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                //on va mettre un zéro dans le canevas1
                                
                                interrogationC1.enabled = true;
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                interrogationC2.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                interrogationC3.enabled = true;
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                interrogationC4.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                interrogationC5.enabled = true;
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                interrogationC6.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                interrogationC7.enabled = true;
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                interrogationC8.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                interrogationC9.enabled = true;
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                interrogationC10.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                interrogationC11.enabled = true;
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                interrogationC12.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                interrogationC13.enabled = true;
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                interrogationC14.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                interrogationC15.enabled = true;
                            }
                        }
                    }

                        if (Nombre[j] == '0')
                    {
                        //print("on va y arriver");
                        //il est important de poser d'entrer qu'on aura à chaque fois deux images par poteau par exemple on reste sur le poteau 1 c'est à dire
                        //les canvas 0 et 1 tant que j=0 ou j=1 comme il y a 8 poteaux il y a 16 canvas (de 0 à15)


                        //on va donc chercher sur quel canvas on met l'image maintenant
                        if (i == 0)//premier poteau car i va de 0 à 7
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre pour trouver le bon canevas
                            {
                                print("prmier chiffre du nombre");
                                //on va donc mettre un zéro sur le canvas0
                                zeroC0.enabled = true;

                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                //on va mettre un zéro dans le canevas1
                                zeroC1.enabled = true;
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                zeroC2.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                zeroC3.enabled = true;
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                zeroC4.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                zeroC5.enabled = true;
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                zeroC6.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                zeroC7.enabled = true;
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                zeroC8.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                zeroC9.enabled = true;
                            }
                        }

                        else if (i == 5)
                        {
                           //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                zeroC10.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                zeroC11.enabled = true;
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                zeroC12.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                zeroC13.enabled = true;
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                                zeroC14.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                                zeroC15.enabled = true;
                            }
                        }

                        


                    }

                    if (Nombre[j] == '1')
                    {
                        //print("on va y arriver");
                        //il est important de poser d'entrer qu'on aura à chaque fois deux images par poteau par exemple on reste sur le poteau 1 c'est à dire
                        //les canvas 0 et 1 tant que j=0 ou j=1 comme il y a 8 poteaux il y a 16 canvas (de 0 à15)


                        //on va donc chercher sur quel canvas on met l'image maintenant
                        if (i == 0)//premier poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                unC0.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                unC1.enabled = true;
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                unC2.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                unC3.enabled = true;
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                unC4.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                unC5.enabled = true;
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                unC6.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                unC7.enabled = true;
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                unC8.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                unC9.enabled = true;
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                unC10.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                unC11.enabled = true;
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                unC12.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                unC13.enabled = true;
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                unC14.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                unC15.enabled = true;
                            }
                        }




                    }

                    if (Nombre[j] == '2')
                    {
                        //print("on va y arriver");
                        //il est important de poser d'entrer qu'on aura à chaque fois deux images par poteau par exemple on reste sur le poteau 1 c'est à dire
                        //les canvas 0 et 1 tant que j=0 ou j=1 comme il y a 8 poteaux il y a 16 canvas (de 0 à15)


                        //on va donc chercher sur quel canvas on met l'image maintenant
                        if (i == 0)//premier poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                deuxC0.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                deuxC1.enabled = true;
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                deuxC2.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                deuxC3.enabled = true;
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                deuxC4.enabled = true;

                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                deuxC5.enabled = true;
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                deuxC6.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                deuxC7.enabled = true;
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                deuxC8.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                deuxC9.enabled = true;
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                deuxC10.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                deuxC11.enabled = true;
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                deuxC12.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                deuxC13.enabled = true;
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                deuxC14.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                deuxC15.enabled = true;
                            }
                        }




                    }

                    if (Nombre[j] == '3')
                    {
                        //print("on va y arriver");
                        //il est important de poser d'entrer qu'on aura à chaque fois deux images par poteau par exemple on reste sur le poteau 1 c'est à dire
                        //les canvas 0 et 1 tant que j=0 ou j=1 comme il y a 8 poteaux il y a 16 canvas (de 0 à15)


                        //on va donc chercher sur quel canvas on met l'image maintenant
                        if (i == 0)//premier poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                troisC0.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                troisC1.enabled = true;
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                troisC2.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                troisC3.enabled = true;
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                troisC4.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                troisC5.enabled = true;
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                troisC6.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                troisC7.enabled = true;
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                troisC8.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                troisC9.enabled = true;
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                troisC10.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                troisC11.enabled = true;
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                troisC12.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                troisC13.enabled = true;
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                troisC14.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                troisC15.enabled = true;
                            }
                        }




                    }

                    if (Nombre[j] == '4')
                    {
                        //print("on va y arriver");
                        //il est important de poser d'entrer qu'on aura à chaque fois deux images par poteau par exemple on reste sur le poteau 1 c'est à dire
                        //les canvas 0 et 1 tant que j=0 ou j=1 comme il y a 8 poteaux il y a 16 canvas (de 0 à15)


                        //on va donc chercher sur quel canvas on met l'image maintenant
                        if (i == 0)//premier poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                quatreC0.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                quatreC1.enabled = true;
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                quatreC2.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                quatreC3.enabled = true;
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                quatreC4.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                quatreC5.enabled = true;
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                quatreC6.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                quatreC7.enabled = true;
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                quatreC8.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                quatreC9.enabled = true;
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                quatreC10.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                quatreC11.enabled = true;
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                quatreC12.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                quatreC13.enabled = true;
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                quatreC14.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                quatreC15.enabled = true;
                            }
                        }




                    }

                    if (Nombre[j] == '5')
                    {
                        //print("on va y arriver");
                        //il est important de poser d'entrer qu'on aura à chaque fois deux images par poteau par exemple on reste sur le poteau 1 c'est à dire
                        //les canvas 0 et 1 tant que j=0 ou j=1 comme il y a 8 poteaux il y a 16 canvas (de 0 à15)


                        //on va donc chercher sur quel canvas on met l'image maintenant
                        if (i == 0)//premier poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                cinqC0.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                cinqC1.enabled = true;
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                cinqC2.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                cinqC3.enabled = true;
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                cinqC4.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                cinqC5.enabled = true;
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                cinqC6.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                cinqC7.enabled = true;
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                cinqC8.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                cinqC9.enabled = true;
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                cinqC10.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                cinqC11.enabled = true;
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                cinqC12.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                cinqC13.enabled = true;
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                cinqC14.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                cinqC15.enabled = true;
                            }
                        }




                    }

                    if (Nombre[j] == '6')
                    {
                        //print("on va y arriver");
                        //il est important de poser d'entrer qu'on aura à chaque fois deux images par poteau par exemple on reste sur le poteau 1 c'est à dire
                        //les canvas 0 et 1 tant que j=0 ou j=1 comme il y a 8 poteaux il y a 16 canvas (de 0 à15)


                        //on va donc chercher sur quel canvas on met l'image maintenant
                        if (i == 0)//premier poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                sixC0.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                sixC1.enabled = true;

                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                sixC2.enabled = true;

                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                sixC3.enabled = true;

                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                sixC4.enabled = true;

                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                sixC5.enabled = true;

                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                sixC6.enabled = true;

                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                sixC7.enabled = true;

                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                sixC8.enabled = true;

                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                sixC9.enabled = true;

                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                sixC10.enabled = true;

                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                sixC11.enabled = true;

                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                sixC12.enabled = true;

                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                sixC13.enabled = true;

                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                sixC14.enabled = true;

                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                sixC15.enabled = true;

                            }
                        }




                    }

                    if (Nombre[j] == '7')
                    {
                        //print("on va y arriver");
                        //il est important de poser d'entrer qu'on aura à chaque fois deux images par poteau par exemple on reste sur le poteau 1 c'est à dire
                        //les canvas 0 et 1 tant que j=0 ou j=1 comme il y a 8 poteaux il y a 16 canvas (de 0 à15)


                        //on va donc chercher sur quel canvas on met l'image maintenant
                        if (i == 0)//premier poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                septC0.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                septC1.enabled = true;
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                septC2.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                septC3.enabled = true;
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                septC4.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                septC5.enabled = true;
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                septC6.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                septC7.enabled = true;
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                septC8.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                septC9.enabled = true;
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                septC10.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                septC11.enabled = true;
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                septC12.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                septC13.enabled = true;
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                septC14.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                septC15.enabled = true;
                            }
                        }




                    }

                    if (Nombre[j] == '8')
                    {
                        //print("on va y arriver");
                        //il est important de poser d'entrer qu'on aura à chaque fois deux images par poteau par exemple on reste sur le poteau 1 c'est à dire
                        //les canvas 0 et 1 tant que j=0 ou j=1 comme il y a 8 poteaux il y a 16 canvas (de 0 à15)


                        //on va donc chercher sur quel canvas on met l'image maintenant
                        if (i == 0)//premier poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                huitC0.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                huitC1.enabled = true;
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                huitC2.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                huitC3.enabled = true;
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                huitC4.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                huitC5.enabled = true;
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                huitC6.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                huitC7.enabled = true;
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                huitC8.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                huitC9.enabled = true;
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                huitC10.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                huitC11.enabled = true;
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                huitC12.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                huitC13.enabled = true;
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                huitC14.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                huitC15.enabled = true;
                            }
                        }




                    }

                    if (Nombre[j] == '9')
                    {
                        //print("on va y arriver");
                        //il est important de poser d'entrer qu'on aura à chaque fois deux images par poteau par exemple on reste sur le poteau 1 c'est à dire
                        //les canvas 0 et 1 tant que j=0 ou j=1 comme il y a 8 poteaux il y a 16 canvas (de 0 à15)


                        //on va donc chercher sur quel canvas on met l'image maintenant
                        if (i == 0)//premier poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                neufC0.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                neufC1.enabled = true;
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                neufC2.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                neufC3.enabled = true;
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                neufC4.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                neufC5.enabled = true;
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                neufC6.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                neufC7.enabled = true;
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                neufC8.enabled = true;

                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                neufC9.enabled = true;
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                neufC10.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                neufC11.enabled = true;
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                neufC12.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                neufC13.enabled = true;
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("premier chiffre du nombre");
                                neufC14.enabled = true;
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième  chiffre du nombre");
                                neufC15.enabled = true;
                            }
                        }




                    }







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
        



       

    }



    //il faut donc faire correpondre à chaque suite sa solution et lorsqu'on va cliquer sur les bons symboles sur le mur; le sphynx se décalera 

  
}
