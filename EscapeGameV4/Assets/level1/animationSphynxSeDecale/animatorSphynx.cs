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
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        string Solution = PlayerPrefs.GetString(solutionSuite);
        print("la solution a la suite est : " + Solution);
        int nombreChiffreSolution = Solution.Length;

        //on va séparer caque chiffre du string en char 
        List<char> charList = new List<char>();
        for(int i=0; i < nombreChiffreSolution; ++i)
        {
            charList.Add(Solution[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (1==2)
        {
            anim.SetBool("SphynxMove", true);
        }
    }
}

