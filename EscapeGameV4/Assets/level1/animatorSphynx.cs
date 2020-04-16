using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorSphynx : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//a terme il faudra mettre si solution = true
        {
            print("je passe dans le sphynx");
            anim.SetBool("SphynxMove", true);
        }
    }
}
