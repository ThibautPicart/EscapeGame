using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class displayText : MonoBehaviour
{
    // Update is called once per frame

    public bool display = true;
    [SerializeField] private Image text;

    void Start()
    {
        //text.enabled = false;
    }

    public void OnMouseDown()
      {
        print("click");
        text.enabled = display;
        display = !display;
      }
    
}
