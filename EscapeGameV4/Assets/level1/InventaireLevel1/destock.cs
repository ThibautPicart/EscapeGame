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

    //Les différents boutons sur le panel inventory
    public Button ButtonTablette1;
    public Button ButtonStick1;
    public Button ButtonKey1;
    public Button ButtonShovel1;
    public Button ButtonTablette2;
    public Button ButtonStick2;
    public Button ButtonKey2;
    public Button ButtonShovel2;
    public Button ButtonTablette3;
    public Button ButtonStick3;
    public Button ButtonKey3;
    public Button ButtonShovel3;
    public Button ButtonTablette4;
    public Button ButtonStick4;
    public Button ButtonKey4;
    public Button ButtonShovel4;
   

    //Le popup de drop
    public GameObject ClickOnItemPanel;
    //Son bouton de drop
    public Button DropItemButton;

    //Les différents panels qui constituent l'inventaire
    public GameObject TablettePanel1;
    public GameObject StickPanel1;
    public GameObject KeyPanel1;
    public GameObject ShovelPanel1;
    public GameObject TablettePanel2;
    public GameObject StickPanel2;
    public GameObject KeyPanel2;
    public GameObject ShovelPanel2;
    public GameObject TablettePanel3;
    public GameObject StickPanel3;
    public GameObject KeyPanel3;
    public GameObject ShovelPanel3;
    public GameObject TablettePanel4;
    public GameObject StickPanel4;
    public GameObject KeyPanel4;
    public GameObject ShovelPanel4;

    public GameObject panelToRemove = null;
    public GameObject objectADrop = null;

    public int pos;

    void Start()
    {

        ButtonTablette1.onClick.AddListener(() => ClickOnBtnTab1());
        ButtonTablette2.onClick.AddListener(() => ClickOnBtnTab2());
        ButtonTablette3.onClick.AddListener(() => ClickOnBtnTab3());
        ButtonTablette4.onClick.AddListener(() => ClickOnBtnTab4());

        ButtonStick1.onClick.AddListener(() => ClickOnBtnStick1());
        ButtonStick2.onClick.AddListener(() => ClickOnBtnStick2());
        ButtonStick3.onClick.AddListener(() => ClickOnBtnStick3());
        ButtonStick4.onClick.AddListener(() => ClickOnBtnStick4());

        ButtonKey1.onClick.AddListener(() => ClickOnBtnKey1());
        ButtonKey2.onClick.AddListener(() => ClickOnBtnKey2());
        ButtonKey3.onClick.AddListener(() => ClickOnBtnKey3());
        ButtonKey4.onClick.AddListener(() => ClickOnBtnKey4());

        ButtonShovel1.onClick.AddListener(() => ClickOnBtnShovel1());
        ButtonShovel2.onClick.AddListener(() => ClickOnBtnShovel2());
        ButtonShovel3.onClick.AddListener(() => ClickOnBtnShovel3());
        ButtonShovel4.onClick.AddListener(() => ClickOnBtnShovel4());


        //Bouton du popup de drop
        DropItemButton.onClick.AddListener(() => ClickOnDropItem());


    }

    //FONCTIONS POUR LA TABLETTE
    public void ClickOnBtnTab1()
    {
        panelToRemove = TablettePanel1;
        objectADrop = tablette;
        ClickOnItemPanel.SetActive(true);
        pos = 1;
    }

    public void ClickOnBtnTab2()

    {
        panelToRemove = TablettePanel2;
        objectADrop = tablette;
        ClickOnItemPanel.SetActive(true);
        pos = 2;
    }

    public void ClickOnBtnTab3()
    {
        panelToRemove = TablettePanel3;
        objectADrop = tablette;
        ClickOnItemPanel.SetActive(true);
        pos = 3;
    }

    public void ClickOnBtnTab4()

    {
        panelToRemove = TablettePanel4;
        objectADrop = tablette;
        ClickOnItemPanel.SetActive(true);
        pos = 4;
    }

    //FONCTIONS POUR LE STICK

    public void ClickOnBtnStick1()

    {
        panelToRemove = StickPanel1;
        objectADrop = stick;
        ClickOnItemPanel.SetActive(true);
        pos = 1;
    }

    public void ClickOnBtnStick2()

    {
        panelToRemove = StickPanel2;
        objectADrop = stick;
        ClickOnItemPanel.SetActive(true);
        pos = 2;
    }

    public void ClickOnBtnStick3()

    {
        panelToRemove = StickPanel3;
        objectADrop = stick;
        ClickOnItemPanel.SetActive(true);
        pos = 3;
    }

    public void ClickOnBtnStick4()

    {
        panelToRemove = StickPanel4;
        objectADrop = stick;
        ClickOnItemPanel.SetActive(true);
        pos = 4;
    }

    //FONCTIONS POUR LA CLE
    public void ClickOnBtnKey1()
    {
        panelToRemove = KeyPanel1;
        objectADrop = key;
        ClickOnItemPanel.SetActive(true);
        pos = 1;
    }

    public void ClickOnBtnKey2()
    {
        panelToRemove = KeyPanel2;
        objectADrop = key;
        ClickOnItemPanel.SetActive(true);
        pos = 2;
    }

    public void ClickOnBtnKey3()
    {
        panelToRemove = KeyPanel3;
        objectADrop = key;
        ClickOnItemPanel.SetActive(true);
        pos = 3;
    }

    public void ClickOnBtnKey4()
    {
        panelToRemove = KeyPanel4;
        objectADrop = key;
        ClickOnItemPanel.SetActive(true);
        pos = 4;
    }

    //FONCTIONS POUR LA PELLE
    public void ClickOnBtnShovel1()
    {
        panelToRemove = ShovelPanel1;
        objectADrop = shovel;
        ClickOnItemPanel.SetActive(true);
        pos = 1;
    }

    public void ClickOnBtnShovel2()
    {
        panelToRemove = ShovelPanel2;
        objectADrop = shovel;
        ClickOnItemPanel.SetActive(true);
        pos = 2;
    }

    public void ClickOnBtnShovel3()
    {
        panelToRemove = ShovelPanel3;
        objectADrop = shovel;
        ClickOnItemPanel.SetActive(true);
        pos = 3;
    }

    public void ClickOnBtnShovel4()
    {
        panelToRemove = ShovelPanel4;
        objectADrop = shovel;
        ClickOnItemPanel.SetActive(true);
        pos = 4;
    }







    public void ClickOnDropItem()
    {
        objectADrop.transform.position = player.transform.position;
        objectADrop.SetActive(true);
        panelToRemove.SetActive(false);
        ClickOnItemPanel.SetActive(false);
        PlayerPrefs.SetInt("EmplacementDispoPref", PlayerPrefs.GetInt("EmplacementDispoPref") - 1);
        tablette.GetComponent<stock>().MiseAJourItems(pos);
    }


}
