using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class click : MonoBehaviour
{
    // Update is called once per frame

    public bool display = true;

    public Texture2D text;

    void OnGui()
    {
        if(display==true)
        {
            GUI.DrawTexture(new Rect(10, 10, 60, 60), text, ScaleMode.ScaleToFit, true, 10.0f);
        }
    }


    void OnMouseDown()
      {
        display = !display;
      }
    
}
