using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class animatorSphynx : MonoBehaviour
{

    //pour mettre du son quand le sphynx se décale
    public AudioSource sonSphynx;

    //pour mettre du son quand les pierres sont pousées où tirées par le personnage
    public AudioSource sonPierres;
    //
    public AudioSource egypte;

    //pour récuperer la solution associée à la suite qui a été tirée au sort dans le script enigme
    private static readonly string solutionSuite = "solutionSuite";
    private Animator anim;
    public Animator zeroPousse;
    public Animator unPousse;
    public Animator deuxPousse;
    public Animator troisPousse;
    public Animator quatrePousse;
    public Animator cinqPousse;
    public Animator sixPousse;
    public Animator septPousse;
    public Animator huitPousse;
    public Animator neufPousse;
    

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

    //pour faire la temporisation avnt de faire monter l'excalier une fois que le sphynx s'est bougé
    public float tempsTemporisation = 30;

    //pour l'animation de l'escalier
    public Animator escalier;


    // Start is called before the first frame update
    void Start()
    {
        //print("byhubhjkl,;");
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


    //pour la temporisation

    IEnumerator sphynxCoroutine()
    {
        //pn ecris le temps la premiere fois que la fonction est appelée
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for x seconds.
        yield return new WaitForSeconds(10);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        escalier.SetBool("escalierMonte", true);
        sonSphynx.Stop();
    }
    public void zeroClick()
    {
        zero=!zero;
        if (zero)
        {
            reponse.Add('0');
            zeroPousse.SetBool("0Pousse", true);
            zeroPousse.SetBool("0comeback", false);
            sonPierres.Play();
            

        }
        else
        {
            reponse.Remove('0');
            zeroPousse.SetBool("0comeback", true);
            zeroPousse.SetBool("0Pousse", false);
            sonPierres.Play();
        }
        
        Reponse();


    }

    public void unClick()
    {
        un = !un;
        if (un)
        {
            reponse.Add('1');
            unPousse.SetBool("1move", true);
            unPousse.SetBool("1comeback", false);
            sonPierres.Play();
        }
        else
        {
            reponse.Remove('1');
            unPousse.SetBool("1comeback", true);
            unPousse.SetBool("1move", false);
            sonPierres.Play();
        }
        
        Reponse();

    }

    public void deuxClick()
    {
        deux = !deux;
        if (deux)
        {
            reponse.Add('2');
            deuxPousse.SetBool("2move",true);
            deuxPousse.SetBool("2comeback", false);
            sonPierres.Play();
        }
        else
        {
            reponse.Remove('2');
            deuxPousse.SetBool("2move", false);
            deuxPousse.SetBool("2comeback", true);
            sonPierres.Play();
        }
        Reponse();


    }
    public void troisClick()
    {
        trois = !trois;
        if (trois)
        {
            reponse.Add('3');
            troisPousse.SetBool("3move", true);
            troisPousse.SetBool("3comeback", false);
            sonPierres.Play();
        }
        else
        {
            reponse.Remove('3');
            troisPousse.SetBool("3move", false);
            troisPousse.SetBool("3comeback", true);
            sonPierres.Play();
        }
        Reponse();


    }
    public void quatreClick()
    {
        quatre = !quatre;
        if (quatre)
        {
            reponse.Add('4');
            quatrePousse.SetBool("4move", true);
            quatrePousse.SetBool("4comeback", false);
            sonPierres.Play();
        }
        else
        {
            reponse.Remove('4');
            quatrePousse.SetBool("4move", false);
            quatrePousse.SetBool("4comeback", true);
            sonPierres.Play();
        }
        Reponse();


    }
    public void cinqClick()
    {
        cinq = !cinq;
        if (cinq)
        {
            reponse.Add('5');
            cinqPousse.SetBool("5move", true);
            cinqPousse.SetBool("5comeback", false);
            sonPierres.Play();
        }
        else
        {
            reponse.Remove('5');
            cinqPousse.SetBool("5move", false);
            cinqPousse.SetBool("5comeback", true);
            sonPierres.Play();
        }
        Reponse();


    }
    public void sixClick()
    {
        six = !six;
        if (six)
        {
            reponse.Add('6');
            sixPousse.SetBool("6move", true);
            sixPousse.SetBool("6comeback", false);
            sonPierres.Play();
        }
        else
        {
            reponse.Remove('6');
            sixPousse.SetBool("6move", false);
            sixPousse.SetBool("6comeback", true);
            sonPierres.Play();
        }
        Reponse();


    }
    public void septClick()
    {
        sept = !sept;
        if (sept)
        {
            reponse.Add('7');
            septPousse.SetBool("7move", true);
            septPousse.SetBool("7comeback", false);
            sonPierres.Play();
        }
        else
        {
            reponse.Remove('7');
            septPousse.SetBool("7move", false);
            septPousse.SetBool("7comeback", true);
            sonPierres.Play();
        }
        Reponse();

    }
    public void huitClick()
    {
        huit = !huit;
        if (huit)
        {
            reponse.Add('8');
            huitPousse.SetBool("8move", true);
            huitPousse.SetBool("8comeback", false);
            sonPierres.Play();
        }
        else
        {
            reponse.Remove('8');
            huitPousse.SetBool("8move", false);
            huitPousse.SetBool("8comeback", true);
            sonPierres.Play();
        }
        Reponse();



    }
    public void neufClick()
    {
        neuf = !neuf;
        if (neuf)
        {
            reponse.Add('9');
            neufPousse.SetBool("9move", true);
            neufPousse.SetBool("9comeback", false);
            sonPierres.Play();
        }
        else
        {
            reponse.Remove('9');
            neufPousse.SetBool("9move", false);
            neufPousse.SetBool("9comeback", true);
            sonPierres.Play();
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


        int variableFin = 0;
        if (result==true && detect==false&&variableFin==0)
            //varaibleFin sert à ne passer qu'une seul fois dans cette fonction
        {
            print("bonne réponse");
            anim.SetBool("SphynxMove", true);
            sonSphynx.Play();

            //pour la temporisation
            StartCoroutine(sphynxCoroutine());
            variableFin = 1;

        }
        
        
    }
}

