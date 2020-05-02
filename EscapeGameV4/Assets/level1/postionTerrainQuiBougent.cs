using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postionTerrainQuiBougent : MonoBehaviour
{
    public GameObject terrainsDroiteGaucheSphynx;
    // Start is called before the first frame update
    void Start()
    {

        //il a fallut commencer en mettant des valeur de position au hasard et voir où le game object se mettait pour voir la
        //position du repère du gameObjecte.
        //ensuite il conviendra de placer ce gameObject constitué de 2 terrains par rapport au repere dans lequel je vais tracer les équations


        //on remarque donc lorsque x augmente, on va de la tête du sphyn vers le mur aux equations
        //si x vaut 56 => je suis aux pattes du sphynx => on laisse tout le temps x à 56 
        //si y augmente, le sol monte => on laisse y a 0
        //si on augmente z,on va vers a gauche du sphynx
        //si z=11 => le trou est collé au mur gauche
        //si z=-12.6 => le trou est collé au mur droit


      terrainsDroiteGaucheSphynx.transform.localPosition = new Vector3(56f,0f,0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
