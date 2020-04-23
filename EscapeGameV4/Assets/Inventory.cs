using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryCanvas;



    void Start()
    {
        PlayerPrefs.SetInt("EmplacementDispoPref", 1); // On initialise le premier emplacement dispo de l'inventaire
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            InventoryCanvas.SetActive(!InventoryCanvas.activeSelf);
        }
    }
}
