using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryCanvas;
    public GameObject HelpPopup;
    public GameObject camera2;
    public InputField inputField;

    //liste des items que l'on peut ramasser
    public GameObject tablette;
    public GameObject stick;

    //Le joueur
    public GameObject player;

    //Déclaration de la liste de ces items
    public List<GameObject> items;

    //Pour savoir si c'est la premiere fois qu'on s'approche d'un item
    public int firstTime;


    void Start()
    {
        PlayerPrefs.SetInt("EmplacementDispoPref", 1); // On initialise le premier emplacement dispo de l'inventaire
        items = new List<GameObject>() { tablette, stick };
        firstTime = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i") && inputField.isFocused == false)
        {
            InventoryCanvas.SetActive(!InventoryCanvas.activeSelf);
            camera2.SetActive(!camera2.activeSelf);
            player.SetActive(!player.activeSelf);
        }

        foreach(GameObject item in items)
        {
            if((Vector3.Distance(item.transform.position, player.transform.position)) < 2 && firstTime==0)
            {
                //On affiche le conseil
                HelpPopup.SetActive(true);
                firstTime = -1;
            }
        }

    }
}
