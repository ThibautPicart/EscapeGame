using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class equations : MonoBehaviour
{

    public GameObject equation;


    //equation niveau facile sont des droites f(x)= ax+b

    //on donne en premier le coefficient directeur a et en seconde position l'ordonée à l'origine b
    //float[] droite1 = new float { 1, 0 };
    //float[] droite2 = new float { 2, 0 };


    //intermédiaire cercle

    //difficile elypse

    // Start is called before the first frame update
    void Start()
    {
        TMP_Text equationText = equation.GetComponent<TMP_Text>();
        equationText.SetText("bonjour");
        //equation.text = "bonjour";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
