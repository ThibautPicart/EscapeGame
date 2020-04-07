using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ce script nous sert à faire en sorte que le son ne se supprimme pas quand une passe d'une scène à l'autre et qu'
 * une nouvelle source ne se crée pas à chaque changement de scène
 */

public class SimpleSingleton : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    //Play Global
    private static SimpleSingleton instance = null;

    public static SimpleSingleton Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    //Play Gobal End

    // Update is called once per frame
    void Update()
    {

    }
}
