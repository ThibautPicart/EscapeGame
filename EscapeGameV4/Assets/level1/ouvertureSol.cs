using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ouvertureSol : MonoBehaviour
{
    public Animator personnageAnim;

    public GameObject player;
    public GameObject solAOuvrir;

    // Update is called once per frame
    void Update()
    {
        
        //j'ai remi là pour éviter d'utiliser les playerprefs
        if (Input.GetKeyDown("c"))
        {
            personnageAnim.SetBool("dig", true);

            if ((Vector3.Distance(solAOuvrir.transform.position, player.transform.position)) < 3 && PlayerPrefs.GetInt("HasShovel") == 1)
            {
                solAOuvrir.SetActive(false);
            }
        }
        if (!Input.GetKeyDown("c"))
        {
            personnageAnim.SetBool("dig", false);
        }

    }
}
