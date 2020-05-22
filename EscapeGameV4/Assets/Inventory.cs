using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryCanvas;
    public GameObject HelpPopup;
    public InputField inputField;

    //liste des items que l'on peut ramasser
    public GameObject tablette;
    public GameObject stick;
    public GameObject key;
    public GameObject shovel;
    public GameObject book;

    //Le joueur
    public GameObject player;

    //Déclaration de la liste de ces items
    public List<GameObject> items;

    public int firstTime;


    void Start()
    {
        PlayerPrefs.SetInt("EmplacementDispoPref", 1); // On initialise le premier emplacement dispo de l'inventaire
        items = new List<GameObject>() { tablette, stick, key, shovel, book};
        firstTime = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i") && inputField.isFocused == false)
        {
            InventoryCanvas.SetActive(!InventoryCanvas.activeSelf);
            player.transform.position = new Vector3(player.transform.position.x, 0.08f, player.transform.position.z); //sinon bug de chute du player
            player.SetActive(!player.activeSelf);
        }

        foreach (GameObject item in items)
        {
            if ((Vector3.Distance(item.transform.position, player.transform.position)) < 2 && firstTime == 0)
            {
                if(item.name!="key" && item.name!="book")
                {
                    //On affiche le conseil
                    HelpPopup.SetActive(true);
                    firstTime = -1;
                }
                
            }
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            HelpPopup.SetActive(false);
        }

    }
}

