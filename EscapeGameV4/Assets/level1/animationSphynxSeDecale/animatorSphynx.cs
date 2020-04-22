using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class animatorSphynx : MonoBehaviour
{
    //pour récuperer la solution associée à la suite qui a été tirée au sort dans le script enigme
    private static readonly string solutionSuite = "solutionSuite";
    private Animator anim;

    //liste des images du murs pour voir si le joueur a cliqué dessus
    public Image zeroMur;
    public Image unMur;
    public Image deuxMur;
    public Image troisMur;
    public Image quatreMur;
    public Image cinqMur;
    public Image sixMur;
    public Image septMur;
    public Image huitMur;
    public Image neufMur;

    //on initialise toute les bouton à false pour dire que de base ils ne sont pas cliqués
    bool zero = false;
    bool un = false;
    bool deux = false;
    bool trois = false;
    bool quatre = false;
    bool cinq = false;
    bool six = false;
    bool sept = false;
    bool huit = false;
    bool neuf = false;

    //on va séparer caque chiffre du string en char 
    List<char> charList = new List<char>();

    //je crée une liste de char ou l'on ajoutera un char a cette liste des que le joeur va cliquer sur un symbole sur le mur
    List<char> reponse = new List<char>();


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        string Solution = PlayerPrefs.GetString(solutionSuite);
        print("la solution a la suite est : " + Solution);
        int nombreChiffreSolution = Solution.Length;

        //on va séparer caque chiffre du string en char 
       
        for(int i=0; i < nombreChiffreSolution; ++i)
        {
            charList.Add(Solution[i]);
        }
    }

    public void zeroClick()
    {
        zero=!zero;
        if (zero)
        {
            reponse.Add('0');
        }
        else
        {
            reponse.Remove('0');
        }
        
        Reponse();


    }

    public void unClick()
    {
        un = !un;
        if (un)
        {
            reponse.Add('1');
        }
        else
        {
            reponse.Remove('1');
        }
        
        Reponse();

    }

    public void deuxClick()
    {
        deux = !deux;
        if (deux)
        {
            reponse.Add('2');
        }
        else
        {
            reponse.Remove('2');
        }
        Reponse();


    }
    public void troisClick()
    {
        trois = !trois;
        if (trois)
        {
            reponse.Add('3');
        }
        else
        {
            reponse.Remove('3');
        }
        Reponse();


    }
    public void quatreClick()
    {
        quatre = !quatre;
        if (quatre)
        {
            reponse.Add('4');
        }
        else
        {
            reponse.Remove('4');
        }
        Reponse();


    }
    public void cinqClick()
    {
        cinq = !cinq;
        if (cinq)
        {
            reponse.Add('5');
        }
        else
        {
            reponse.Remove('5');
        }
        Reponse();


    }
    public void sixClick()
    {
        six = !six;
        if (six)
        {
            reponse.Add('6');
        }
        else
        {
            reponse.Remove('6');
        }
        Reponse();


    }
    public void septClick()
    {
        sept = !sept;
        if (sept)
        {
            reponse.Add('7');
        }
        else
        {
            reponse.Remove('7');
        }
        Reponse();

    }
    public void huitClick()
    {
        huit = !huit;
        if (huit)
        {
            reponse.Add('8');
        }
        else
        {
            reponse.Remove('8');
        }
        Reponse();



    }
    public void neufClick()
    {
        neuf = !neuf;
        if (neuf)
        {
            reponse.Add('9');
        }
        else
        {
            reponse.Remove('9');
        }
        Reponse();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reponse()
    {
        print("je suis dans la fonction reponse");
        print("reponse: " );
        for (int i= 0;i< reponse.Count; ++i)
        {
            print(reponse[i]);
        }
        print("charList : ");
        for (int i = 0; i < charList.Count; ++i)
        {
            print(charList[i]);
        }

        bool result = false;
        bool detect = false;
        if (charList.Count == reponse.Count)
        {
            for (int i = 0; i < charList.Count; ++i)
            {

                if (reponse[i] == charList[i])
                {
                    result = true;
                }
                else
                {
                    detect = true;
                }
            }
        }
       
        

        if (result==true && detect==false)
        {
            print("bonne réponse");
            anim.SetBool("SphynxMove", true);
        }
        
        
    }
}

