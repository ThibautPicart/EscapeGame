using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class displayText : MonoBehaviour
{
    // Update is called once per frame


    public GameObject text;
    [SerializeField] private Image croix;

    void Start()
    {
        //text.enabled = false;
    }

    public void OnMouseDown()
      {
        text.SetActive(true); ;
        croix.enabled = true;
        
      }

    public void exitImage()
    {
        text.SetActive(false);
        croix.enabled = false;
        
    }
    
}
