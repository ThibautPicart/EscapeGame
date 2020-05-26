using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class destock : MonoBehaviour
{
    public GameObject player;

    //Nos gameobject de la scène
    public GameObject tablette;
    public GameObject stick;
    public GameObject key;
    public GameObject shovel;
    public GameObject book;

    //Les différents boutons sur le panel inventory
    public Button ButtonTablette1;
    public Button ButtonStick1;
    public Button ButtonKey1;
    public Button ButtonShovel1;
    public Button ButtonBook1;
    public Button ButtonTablette2;
    public Button ButtonStick2;
    public Button ButtonKey2;
    public Button ButtonShovel2;
    public Button ButtonBook2;
    public Button ButtonTablette3;
    public Button ButtonStick3;
    public Button ButtonKey3;
    public Button ButtonShovel3;
    public Button ButtonBook3;
    public Button ButtonTablette4;
    public Button ButtonStick4;
    public Button ButtonKey4;
    public Button ButtonShovel4;
    public Button ButtonBook4;
    public Button ButtonTablette5;
    public Button ButtonStick5;
    public Button ButtonKey5;
    public Button ButtonShovel5;
    public Button ButtonBook5;


    //Le popup de drop
    public GameObject ClickOnItemPanel;
    public GameObject ClickOnShovelPanel;
    public GameObject ClickOnBookPanel;

    //Son bouton de drop
    public Button DropItemButton;
    public Button DropShovelButton;
    public Button DropBookButton;

    //Les différents panels qui constituent l'inventaire
    public GameObject TablettePanel1;
    public GameObject StickPanel1;
    public GameObject KeyPanel1;
    public GameObject ShovelPanel1;
    public GameObject BookPanel1;
    public GameObject TablettePanel2;
    public GameObject StickPanel2;
    public GameObject KeyPanel2;
    public GameObject ShovelPanel2;
    public GameObject BookPanel2;
    public GameObject TablettePanel3;
    public GameObject StickPanel3;
    public GameObject KeyPanel3;
    public GameObject ShovelPanel3;
    public GameObject BookPanel3;
    public GameObject TablettePanel4;
    public GameObject StickPanel4;
    public GameObject KeyPanel4;
    public GameObject ShovelPanel4;
    public GameObject BookPanel4;
    public GameObject TablettePanel5;
    public GameObject StickPanel5;
    public GameObject KeyPanel5;
    public GameObject ShovelPanel5;
    public GameObject BookPanel5;

    public GameObject handShovel;

    private GameObject panelToRemove = null;
    private GameObject objectADrop = null;

    private int pos;

    void Start()
    {

        ButtonTablette1.onClick.AddListener(() => ClickOnBtnTab(1));
        ButtonTablette2.onClick.AddListener(() => ClickOnBtnTab(2));
        ButtonTablette3.onClick.AddListener(() => ClickOnBtnTab(3));
        ButtonTablette4.onClick.AddListener(() => ClickOnBtnTab(4));
        ButtonTablette5.onClick.AddListener(() => ClickOnBtnTab(5));

        ButtonStick1.onClick.AddListener(() => ClickOnBtnStick(1));
        ButtonStick2.onClick.AddListener(() => ClickOnBtnStick(2));
        ButtonStick3.onClick.AddListener(() => ClickOnBtnStick(3));
        ButtonStick4.onClick.AddListener(() => ClickOnBtnStick(4));
        ButtonStick5.onClick.AddListener(() => ClickOnBtnStick(5));

        ButtonKey1.onClick.AddListener(() => ClickOnBtnKey(1));
        ButtonKey2.onClick.AddListener(() => ClickOnBtnKey(2));
        ButtonKey3.onClick.AddListener(() => ClickOnBtnKey(3));
        ButtonKey4.onClick.AddListener(() => ClickOnBtnKey(4));
        ButtonKey5.onClick.AddListener(() => ClickOnBtnKey(5));

        ButtonShovel1.onClick.AddListener(() => ClickOnBtnShovel(1));
        ButtonShovel2.onClick.AddListener(() => ClickOnBtnShovel(2));
        ButtonShovel3.onClick.AddListener(() => ClickOnBtnShovel(3));
        ButtonShovel4.onClick.AddListener(() => ClickOnBtnShovel(4));
        ButtonShovel5.onClick.AddListener(() => ClickOnBtnShovel(5));

        ButtonBook1.onClick.AddListener(() => ClickOnBtnBook(1));
        ButtonBook2.onClick.AddListener(() => ClickOnBtnBook(2));
        ButtonBook3.onClick.AddListener(() => ClickOnBtnBook(3));
        ButtonBook4.onClick.AddListener(() => ClickOnBtnBook(4));
        ButtonBook5.onClick.AddListener(() => ClickOnBtnBook(5));

        //Bouton du popup de drop
        DropItemButton.onClick.AddListener(() => ClickOnDropItem());
        DropShovelButton.onClick.AddListener(() => ClickOnDropItem());
        DropBookButton.onClick.AddListener(() => ClickOnDropItem());

    }

    //FONCTIONS POUR LA TABLETTE
    public void ClickOnBtnTab(int emplacement)
    {
        if (emplacement == 1) { panelToRemove = TablettePanel1; }
        if (emplacement == 2) { panelToRemove = TablettePanel2; }
        if (emplacement == 3) { panelToRemove = TablettePanel3; }
        if (emplacement == 4) { panelToRemove = TablettePanel4; }
        if (emplacement == 5) { panelToRemove = TablettePanel5; }
        objectADrop = tablette;
        ClickOnItemPanel.SetActive(true);
        pos = 1;
    }

   

    //FONCTIONS POUR LE STICK

    public void ClickOnBtnStick(int emplacement)

    {
        if (emplacement == 1) { panelToRemove = StickPanel1; }
        if (emplacement == 2) { panelToRemove = StickPanel2; }
        if (emplacement == 3) { panelToRemove = StickPanel3; }
        if (emplacement == 4) { panelToRemove = StickPanel4; }
        if (emplacement == 5) { panelToRemove = StickPanel5; }
        objectADrop = stick;
        ClickOnItemPanel.SetActive(true);
        pos = emplacement;
    }


    //FONCTIONS POUR LA CLE
    public void ClickOnBtnKey(int emplacement)
    {
        if (emplacement == 1) { panelToRemove = KeyPanel1; }
        if (emplacement == 2) { panelToRemove = KeyPanel2; }
        if (emplacement == 3) { panelToRemove = KeyPanel3; }
        if (emplacement == 4) { panelToRemove = KeyPanel4; }
        if (emplacement == 5) { panelToRemove = KeyPanel5; }
        objectADrop = key;
        ClickOnItemPanel.SetActive(true);
        pos = emplacement;
    }



    //FONCTIONS POUR LA PELLE
    public void ClickOnBtnShovel(int emplacement)
    {
        if (emplacement == 1) { panelToRemove = ShovelPanel1; }
        if (emplacement == 2) { panelToRemove = ShovelPanel2; }
        if (emplacement == 3) { panelToRemove = ShovelPanel3; }
        if (emplacement == 4) { panelToRemove = ShovelPanel4; }
        if (emplacement == 5) { panelToRemove = ShovelPanel5; }
        objectADrop = shovel;
        ClickOnShovelPanel.SetActive(true);
        pos = emplacement;
    }

    //FONCTIONS POUR LE LIVRE
    public void ClickOnBtnBook(int emplacement)
    {
        if (emplacement == 1) { panelToRemove = BookPanel1; }
        if (emplacement == 2) { panelToRemove = BookPanel2; }
        if (emplacement == 3) { panelToRemove = BookPanel3; }
        if (emplacement == 4) { panelToRemove = BookPanel4; }
        if (emplacement == 5) { panelToRemove = BookPanel5; }
        objectADrop = book;
        ClickOnBookPanel.SetActive(true);
        pos = emplacement;
    }


    public void ClickOnDropItem()
    {
        objectADrop.transform.position = player.transform.position + new Vector3(0,1.0f,0);
        objectADrop.SetActive(true);
        if(objectADrop.name == "key")
        {
            PlayerPrefs.SetInt("HasKey", 0);
        }
        if (objectADrop.name == "shovel")
        {
            handShovel.SetActive(false);
        }
        panelToRemove.SetActive(false);
        ClickOnItemPanel.SetActive(false);
        ClickOnShovelPanel.SetActive(false);
        ClickOnBookPanel.SetActive(false);

        PlayerPrefs.SetInt("EmplacementDispoPref", PlayerPrefs.GetInt("EmplacementDispoPref") - 1);
        tablette.GetComponent<stock>().MiseAJourItems(pos);
    }
 
 

}
