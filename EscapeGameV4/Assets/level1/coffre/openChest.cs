using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openChest : MonoBehaviour
{
    public GameObject player;
    public GameObject helpPopup;
    private Animator openCover;


    private int firstTime;

    void Start()
    {
        openCover = GetComponent<Animator>();
        firstTime = 1;
        PlayerPrefs.SetInt("isChestOpen", 0);
    }
    void Update()
    {
        if((Vector3.Distance(transform.position, player.transform.position)) < 2 && PlayerPrefs.GetInt("HasKey") == 1)
        {
            //si on est près du coffre et que l'on possède la clé, on affiche le popup
            if(firstTime == 1)
            {
                helpPopup.SetActive(true);
                firstTime = 0;
            }
            
            if(Input.GetKeyDown("o"))
            {
                openCover.SetBool("openCoffre", true);
                PlayerPrefs.SetInt("isChestOpen", 1);
            }
        }

        if(Input.GetKeyDown("enter"))
        {
            helpPopup.SetActive(false);
        }

        
    }


}
