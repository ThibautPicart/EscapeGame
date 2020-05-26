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
    public Animator cubeAnim0;
    public Animator cubeAnim1;
    public Animator cubeAnim2;
    public Animator cubeAnim3;
    public Animator cubeAnim4;
    public Animator cubeAnim5;
    public Animator cubeAnim6;
    public Animator cubeAnim7;
    public Animator cubeAnim8;
    public Animator cubeAnim9;

    public GameObject cube0, cube1, cube2, cube3, cube4, cube5, cube6, cube7, cube8, cube9;




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

    //anim perso
    private Animator personnageAnim;

    //le perso
    public GameObject player;

    //public Button Btn1;


    // Start is called before the first frame update
    void Start()
    {
        personnageAnim = player.GetComponent<Animator>();
        anim = GetComponent<Animator>();
        string Solution = PlayerPrefs.GetString(solutionSuite);
        //print("la solution a la suite est : " + Solution);
        int nombreChiffreSolution = Solution.Length;

        //on va séparer caque chiffre du string en char 
       
        for(int i=0; i < nombreChiffreSolution; ++i)
        {
            charList.Add(Solution[i]);
        }



        //test
        //Btn1.onClick.AddListener(() => unClick());


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
        if ((Vector3.Distance(cube0.transform.position, player.transform.position)) < 4)
        {
            zero = !zero;
            if (zero)
            {
                reponse.Add('0');
                cubeAnim0.SetBool("move", true);
                cubeAnim0.SetBool("comeback", false);
                sonPierres.Play();
                personnageAnim.SetBool("push", true);


            }
            else
            {
                reponse.Remove('0');
                cubeAnim0.SetBool("move", false);
                cubeAnim0.SetBool("comeback", true);
                sonPierres.Play();
                personnageAnim.SetBool("pull", true);
            }

            Reponse();
        }
        


    }

    public void unClick()
    {
        if ((Vector3.Distance(cube1.transform.position, player.transform.position)) < 4)
        {
            un = !un;
            if (un)
            {

                reponse.Add('1');
                cubeAnim1.SetBool("move", true);
                cubeAnim1.SetBool("comeback", false);
                sonPierres.Play();
                personnageAnim.SetBool("push", true);
            }
            else
            {
                reponse.Remove('1');
                cubeAnim1.SetBool("move", false);
                cubeAnim1.SetBool("comeback", true);
                sonPierres.Play();
                personnageAnim.SetBool("pull", true);
            }

            Reponse();
        }

        

    }

    public void deuxClick()
    {
        if ((Vector3.Distance(cube2.transform.position, player.transform.position)) < 4)
        {
            deux = !deux;
            if (deux)
            {
                reponse.Add('2');
                cubeAnim2.SetBool("move", true);
                cubeAnim2.SetBool("comeback", false);
                sonPierres.Play();
                personnageAnim.SetBool("push", true);
            }
            else
            {
                reponse.Remove('2');
                cubeAnim2.SetBool("move", false);
                cubeAnim2.SetBool("comeback", true);
                sonPierres.Play();
                personnageAnim.SetBool("pull", true);
            }
            Reponse();
        }
        


    }
    public void troisClick()
    {
        if ((Vector3.Distance(cube3.transform.position, player.transform.position)) < 4)
        {
            trois = !trois;
            if (trois)
            {
                reponse.Add('3');
                cubeAnim3.SetBool("move", true);
                cubeAnim3.SetBool("comeback", false);
                sonPierres.Play();
                personnageAnim.SetBool("push", true);
            }
            else
            {
                reponse.Remove('3');
                cubeAnim3.SetBool("move", false);
                cubeAnim3.SetBool("comeback", true);
                sonPierres.Play();
                personnageAnim.SetBool("pull", true);
            }
            Reponse();
        }
        


    }
    public void quatreClick()
    {
        if ((Vector3.Distance(cube4.transform.position, player.transform.position)) < 4)
        {
            quatre = !quatre;
            if (quatre)
            {
                reponse.Add('4');
                cubeAnim4.SetBool("move", true);
                cubeAnim4.SetBool("comeback", false);
                sonPierres.Play();
                personnageAnim.SetBool("push", true);
            }
            else
            {
                reponse.Remove('4');
                cubeAnim4.SetBool("move", false);
                cubeAnim4.SetBool("comeback", true);
                sonPierres.Play();
                personnageAnim.SetBool("pull", true);
            }
            Reponse();
        }
        


    }
    public void cinqClick()
    {
        if ((Vector3.Distance(cube5.transform.position, player.transform.position)) < 4)
        {
            cinq = !cinq;
            if (cinq)
            {
                reponse.Add('5');
                cubeAnim5.SetBool("move", true);
                cubeAnim5.SetBool("comeback", false);
                sonPierres.Play();
                personnageAnim.SetBool("push", true);
            }
            else
            {
                reponse.Remove('5');
                cubeAnim5.SetBool("move", false);
                cubeAnim5.SetBool("comeback", true);
                sonPierres.Play();
                personnageAnim.SetBool("pull", true);
            }
            Reponse();
        }
        


    }
    public void sixClick()
    {
        if ((Vector3.Distance(cube6.transform.position, player.transform.position)) < 4)
        {
            six = !six;
            if (six)
            {
                reponse.Add('6');
                cubeAnim6.SetBool("move", true);
                cubeAnim6.SetBool("comeback", false);
                sonPierres.Play();
                personnageAnim.SetBool("push", true);
            }
            else
            {
                reponse.Remove('6');
                cubeAnim6.SetBool("move", false);
                cubeAnim6.SetBool("comeback", true);
                sonPierres.Play();
                personnageAnim.SetBool("pull", true);
            }
            Reponse();
        }
        


    }
    public void septClick()
    {
        if ((Vector3.Distance(cube7.transform.position, player.transform.position)) < 4)
        {
            sept = !sept;
            if (sept)
            {
                reponse.Add('7');
                cubeAnim7.SetBool("move", true);
                cubeAnim7.SetBool("comeback", false);
                sonPierres.Play();
                personnageAnim.SetBool("push", true);
            }
            else
            {
                reponse.Remove('7');
                cubeAnim7.SetBool("move", false);
                cubeAnim7.SetBool("comeback", true);
                sonPierres.Play();
                personnageAnim.SetBool("pull", true);
            }
            Reponse();
        }
        

    }
    public void huitClick()
    {
        if ((Vector3.Distance(cube8.transform.position, player.transform.position)) < 4)
        {
            huit = !huit;
            if (huit)
            {
                reponse.Add('8');
                cubeAnim8.SetBool("move", true);
                cubeAnim8.SetBool("comeback", false);
                sonPierres.Play();
                personnageAnim.SetBool("push", true);
            }
            else
            {
                reponse.Remove('8');
                cubeAnim8.SetBool("move", false);
                cubeAnim8.SetBool("comeback", true);
                sonPierres.Play();
                personnageAnim.SetBool("pull", true);
            }
            Reponse();
        }
        



    }
    public void neufClick()
    {
        if ((Vector3.Distance(cube9.transform.position, player.transform.position)) < 4)
        {
            neuf = !neuf;
            if (neuf)
            {
                reponse.Add('9');
                cubeAnim9.SetBool("move", true);
                cubeAnim9.SetBool("comeback", false);
                sonPierres.Play();
                personnageAnim.SetBool("push", true);
            }
            else
            {
                reponse.Remove('9');
                cubeAnim9.SetBool("move", false);
                cubeAnim9.SetBool("comeback", true);
                sonPierres.Play();
                personnageAnim.SetBool("pull", true);
            }
            Reponse();
        }
        

    }


    public void Reponse()
    {
        //print("je suis dans la fonction reponse");
        //print("reponse: " );
        for (int i= 0;i< reponse.Count; ++i)
        {
            //print(reponse[i]);
        }
        //print("charList : ");
        for (int i = 0; i < charList.Count; ++i)
        {
            //print(charList[i]);
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
            //print("bonne réponse");
            anim.SetBool("SphynxMove", true);
            sonSphynx.Play();

            //pour la temporisation
            StartCoroutine(sphynxCoroutine());
            variableFin = 1;

        }
        
        
    }
}

