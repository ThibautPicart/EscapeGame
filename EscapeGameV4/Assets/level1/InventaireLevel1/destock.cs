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

    //Les différents boutons sur le panel inventory
    public Button ButtonTablette1;
    public Button ButtonStick1;
    public Button ButtonTablette2;
    public Button ButtonStick2;

    //Le popup de drop
    public GameObject ClickOnItemPanel;
    //Son bouton de drop
    public Button DropItemButton;

    //Les différents panels qui constituent l'inventaire
    public GameObject TablettePanel1;
    public GameObject StickPanel1;
    public GameObject TablettePanel2;
    public GameObject StickPanel2;

    public GameObject panelToRemove = null;
    public GameObject objectADrop = null;

    public int pos;

    void Start()
    {
        
        ButtonTablette1.onClick.AddListener(() => ClickOnBtnTab1());

        ButtonStick1.onClick.AddListener(() => ClickOnBtnStick1()); 

        ButtonTablette2.onClick.AddListener(() => ClickOnBtnTab2());

        ButtonStick2.onClick.AddListener(() => ClickOnBtnStick2());

        //Bouton du popup de drop
        DropItemButton.onClick.AddListener(() => ClickOnDropItem());

        

    }

    
    void ClickOnBtnTab1()
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
