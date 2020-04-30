using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class displayText : MonoBehaviour
{
    // Update is called once per frame

   
    public GameObject text;
    public GameObject player;
    public GameObject tablette;


    public void OnMouseDown()
      {
        if ((Vector3.Distance(tablette.transform.position, player.transform.position)) < 2)
        {
            text.SetActive(true);
        }
        
        
      }

}
