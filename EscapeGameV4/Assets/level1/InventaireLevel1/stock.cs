using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stock : MonoBehaviour
{
    //Le joueur
    public GameObject player;

    //Notre objet
    public GameObject myself;
    public int Position;  // sa postion dans les listes d'emplacement

    //On utilise une PlayerPref pour savoir sur quel emplacement on peut afficher notre objet
    private static readonly string EmplacementDispoPref = "EmplacementDispoPref";
    private int EmplacementDispoInt;

    //On récupère tous les Panels
    public GameObject ItemTablette1, ItemStick1, ItemKey1, ItemShovel1, ItemBook1;
    public GameObject ItemTablette2, ItemStick2, ItemKey2, ItemShovel2, ItemBook2;
    public GameObject ItemTablette3, ItemStick3, ItemKey3, ItemShovel3, ItemBook3;
    public GameObject ItemTablette4, ItemStick4, ItemKey4, ItemShovel4, ItemBook4;
    public GameObject ItemTablette5, ItemStick5, ItemKey5, ItemShovel5, ItemBook5;


    //Déclaration des listes de panels correspondants aux objets affichés dans l'inventaire
    public List<GameObject> Emplacement1, Emplacement2, Emplacement3, Emplacement4, Emplacement5;


    //Déclaration de la liste des emplacements
    public List<List<GameObject>> Emplacements;



    void Start()
    {
        Emplacement1 = new List<GameObject>() { ItemTablette1, ItemStick1, ItemKey1, ItemShovel1, ItemBook1 };
        Emplacement2 = new List<GameObject>() { ItemTablette2, ItemStick2, ItemKey2, ItemShovel2, ItemBook2 };
        Emplacement3 = new List<GameObject>() { ItemTablette3, ItemStick3, ItemKey3, ItemShovel3, ItemBook3 };
        Emplacement4 = new List<GameObject>() { ItemTablette4, ItemStick4, ItemKey4, ItemShovel4, ItemBook4 };
        Emplacement5 = new List<GameObject>() { ItemTablette5, ItemStick5, ItemKey5, ItemShovel5, ItemBook5 };

        Emplacements = new List<List<GameObject>> { Emplacement1, Emplacement2, Emplacement3, Emplacement4, Emplacement5 };

        PlayerPrefs.SetInt("KeyOk", 0);
        PlayerPrefs.SetInt("HasKey", 0);
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("t") && Vector3.Distance(myself.transform.position, player.transform.position) < 2)
        {
            if(myself.name == "key")
            {
                if(PlayerPrefs.GetInt("KeyOk") == 1)
                {
                    myself.SetActive(false);  // On enlève de la scène l'objet placé dans l'inventaire
                    StockInTheRightPanel();   // On appelle la fonction qui l'affiche dans l'inventaire
                }
            }

            else if (myself.name == "book")
            {
                if(PlayerPrefs.GetInt("isChestOpen") == 1)
                {
                    myself.SetActive(false);  // On enlève de la scène l'objet placé dans l'inventaire
                    StockInTheRightPanel();   // On appelle la fonction qui l'affiche dans l'inventaire
                }
            }

            else
            {
                myself.SetActive(false);  // On enlève de la scène l'objet placé dans l'inventaire
                StockInTheRightPanel();   // On appelle la fonction qui l'affiche dans l'inventaire
            }
            
        }
    }

    public void StockInTheRightPanel()
    {
        EmplacementDispoInt = PlayerPrefs.GetInt(EmplacementDispoPref); // on récupère l'emplacement qui contiendra notre objet

        if (myself.name == "tablette")
        {
            Position = 0;
        }
        if (myself.name == "WoodStick")
        {
            Position = 1;
        }
        if (myself.name == "key")
        {
            Position = 2;
            PlayerPrefs.SetInt("HasKey", 1);
        }
        if (myself.name == "shovel")
        {
            Position = 3;
        }
        if (myself.name == "book")
        {
            Position = 4;
        }

        Emplacements[EmplacementDispoInt - 1][Position].SetActive(true);
        PlayerPrefs.SetInt(EmplacementDispoPref, EmplacementDispoInt + 1);
    }

    public void MiseAJourItems(int pos)
    {
        for (int i = pos; i < Emplacements.Count; i++)
        {
            for (int j = 0; j < Emplacements[i].Count; j++)
            {
                if (Emplacements[i][j].activeSelf == true)
                {
                    Emplacements[i - 1][j].SetActive(true);
                    Emplacements[i][j].SetActive(false);
                }
            }
        }
    }
}
