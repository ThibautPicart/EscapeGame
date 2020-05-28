using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shovel : MonoBehaviour
{
    public GameObject Shovel;
    public GameObject panel;
    public GameObject helpPanel;
    private int firstTime;

    void Start()
    {
        firstTime = 0;
        PlayerPrefs.SetInt("HasShovel", 0);
    }
    public void ActiveShovel()
    {
        Shovel.SetActive(!Shovel.activeSelf);
        if(Shovel.activeSelf)
        {
            PlayerPrefs.SetInt("HasShovel", 1);
        }
        panel.SetActive(false);
        if(firstTime == 0)
        {
            helpPanel.SetActive(true);
            firstTime = 1;
        }
        
    }
}
