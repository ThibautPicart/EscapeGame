using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ouvertureSol : MonoBehaviour
{
    public Animator personnageAnim;

    public GameObject player;
    public GameObject solAOuvrir;
    bool creuse;

    // Start is called before the first frame update
    void Start()
    {
        creuse = false;
    }

    // Update is called once per frame
    void Update()
    {
        print("creuse=" + creuse);
        
        //j'ai remi là pour éviter d'utiliser les playerprefs
        if (Input.GetKeyDown("c"))
        {
            personnageAnim.SetBool("dig", true);
            creuse = true;
        }
        if (!Input.GetKeyDown("c"))
        {
            personnageAnim.SetBool("dig", false);
            creuse = false;
        }

        //bool creuse = personnageAnim.GetBool("dig");
        //print("creuse = " + creuse);

        if ((Vector3.Distance(solAOuvrir.transform.position, player.transform.position)) < 5 && creuse==true )
        {
            solAOuvrir.SetActive(false);
        }
    }
}
