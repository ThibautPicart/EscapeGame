using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class displayText : MonoBehaviour
{

    [SerializeField] private Image text;
    [SerializeField] private Image croix;

  

    public void OnMouseDown()
      {
        print("click");
        text.enabled = true;
        croix.enabled = true;
      }

    public void exitImage()
    {
        text.enabled = false;
        croix.enabled = false;
    }
    
}
