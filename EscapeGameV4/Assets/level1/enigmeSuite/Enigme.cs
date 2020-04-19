using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enigme : MonoBehaviour
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
    





    //forcement au moment où on lit ce script enigme, on est déjà passé par le menu et il y a donc un niveau de difficulté de selectionné
    private static readonly string levelDifficulty = "levelDifficulty";
    private string levelString;

    // Start is called before the first frame update
    void Start()
    {
        //déclaration des suites faciles
        List<string> SuiteFacile1 = new List<string>() { "0", "2", "3", "4", "5", "6", "7" };
        List<string> SuiteFacile2 = new List<string>() { "0", "4", "6", "8", "10", "12", "14" };

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
                    //print(Nombre[j]);

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
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                            }
                        }

                        else if (i == 5)
                        {
                           //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("prmier chiffre du nombre");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("deuxième chiffre du nombre");
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
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
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
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
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
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
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
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
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
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
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
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
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
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
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
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
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
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }

                        }
                        else if (i == 1)//deuxième poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }
                        else if (i == 2)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 3)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 4)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 5)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else if (i == 6)
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
                            }
                        }

                        else //if (i == 7)//8eme poteau
                        {
                            //on va regarder si on est le premier ou le deuxième chiffre du poteau 0
                            if (j == 0)//si c'est le premier chiffre
                            {
                                print("dcrt");
                            }
                            else//si c'est le deuxième chiffre du nommbre
                            {
                                print("gkjn");
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
        



        //maintenant que nous avons la suite, il convient de faire correspondre à chaque numéro une image

        




    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
