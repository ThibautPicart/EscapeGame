using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionTerrainQuiBougent : MonoBehaviour
{
    //le terrain qui à sa taille qui évolue
    public Terrain terrain;
    
    private Vector3 terrainSize;

    //terrain qu'on va effacer quand on va creuser au bon endroit
    public Terrain terrainAEffacer;


    public GameObject terrainsDroiteGaucheSphynx;
    public GameObject terrainsHautBas;
    public GameObject key;

    //playerPref pour envoyer la solution  au script qui fait bouger les terrains
    private static readonly string xSolutionEquation = "xSolutionEquation";
    private static readonly string ySolutionEquation = "ySolutionEquation";


    // Start is called before the first frame update
    public void MiseEnplaceDuTerrain()
    {

        //il a fallut commencer en mettant des valeur de position au hasard et voir où le game object se mettait pour voir la
        //position du repère du gameObjecte.
        //ensuite il conviendra de placer ce gameObject constitué de 2 terrains par rapport au repere dans lequel je vais tracer les équations


        //on remarque donc lorsque x augmente, on va de la tête du sphynx vers le mur aux equations
        //si x vaut 56 => je suis aux pattes du sphynx => on laisse tout le temps x à 56 
        //si y augmente, le sol monte => on laisse y a 0
        //si on augmente z,on va vers a gauche du sphynx
        //si z=11 => le trou est collé au mur gauche
        //si z=-12.6 => le trou est collé au mur droit
        //z=-0.8=> trou est centré


        //terrainsDroiteGaucheSphynx.transform.localPosition = new Vector3(56f,0f,11f);

        //poue celui-ci quand j'augmente z, il va a gauche du sphynx
        //quand x diminue, on se rapproche du sphynx; on est sencé agir uniquement sur cette composante!
        //si x=-10 => une bande juste devant les pattes ud sphynx (avec la petite marge qu'on a pri pour etre a -36 pile!)
        //terrainsHautBas.transform.localPosition = new Vector3(-10f, 0f, 0f);


        //je simule les coordonée de la solution pour l'instant (4,5) dans le repère du jeu!!!!!
        //il faut voir ce que ca donne dans le repere des terrains droite/gauche
        //après raisonnement sur papier, je trouve: 
        //notons X1,Y1,Z1 les coordonées du repère des terrains de gauche a droite du sphynx
        //X2,Y2,Z2 les coordonnées du repère des tearrain qui s'éloignent ou se rapprochent du sphynx
        //x,y,z les coordonées en prenant pour repère le coin de la map; (celle que le joueur utilisera)
        //=> Z1=11-y
        //=>X2=56+(36-x)

        


            //on récupère la solution à l'aide de playerpref
            string xSolution = PlayerPrefs.GetString(xSolutionEquation);
            print("xsolution: " + xSolution);
            string ySolution = PlayerPrefs.GetString(ySolutionEquation);
            print("ysolution: " + ySolution);

            float xsolutionFloat = float.Parse(xSolution);//pour convertir le string récupéré avec le playerPref en float
            float ysolutionFloat = float.Parse(ySolution);



            float xCle = 49.5f - xsolutionFloat;
            float zCle = 24f - ysolutionFloat;
            float Z1 = 11f - ysolutionFloat;
            float X2 = -11f + 23f - xsolutionFloat;
            //on place la clé a l'endroit qui convient
            key.transform.localPosition = new Vector3(xCle, -0.5f, zCle);

            terrainsDroiteGaucheSphynx.transform.localPosition = new Vector3(56f, 0f, Z1);
            terrainsHautBas.transform.localPosition = new Vector3(X2, 0f, 0f);

            //on vient placer le terrain qui cache le trou au bonne endroit
            float xTerrainAEffacer = 50 - xsolutionFloat;
            float zTerrainAEffacer = 23.5f - ysolutionFloat;
            terrainAEffacer.transform.localPosition = new Vector3(xTerrainAEffacer, 0, zTerrainAEffacer);
            //pour le cacher ou l'afficher si on creuse au bonne endroit
            terrainAEffacer.enabled = true;

            //on va adapter la taille du terrain en fonction afin qu'il n'y est pas de trou dans le sol
            float sizeX = 25f - xsolutionFloat;//Length =>on met 25 car la longueur entre les pattes du sphynx et le mur aux équation vaut 25
            float sizeY = 40f;//width
            float sizeZ = 12f;//height
            terrainSize = new Vector3(sizeY, sizeZ, sizeX);
            terrain.terrainData.size = terrainSize;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
