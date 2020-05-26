using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private CharacterController Player;
    private Animator personnageAnim;
    private Vector3 DirectionalDeplacement = Vector3.zero;
    public float speed = 3;
    public float runSpeed = 6;
    public int jump = 5;
    int gravite = 20;
    public float rotationSensi = 4;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();
        personnageAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DirectionalDeplacement.z = Input.GetAxisRaw("Vertical");
        DirectionalDeplacement.x = Input.GetAxisRaw("Horizontal");
        DirectionalDeplacement = transform.TransformDirection(DirectionalDeplacement);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Player.Move(DirectionalDeplacement * Time.deltaTime * runSpeed);
        }
        else
        {
            Player.Move(DirectionalDeplacement * Time.deltaTime * speed);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(0, rotationSensi, 0);
            personnageAnim.SetBool("rightTurn", true);
        }

        if (!Input.GetKey("d"))
        {
            personnageAnim.SetBool("rightTurn", false);
        }


        if (Input.GetKey("q"))
        {
            transform.Rotate(0, -rotationSensi, 0);
            personnageAnim.SetBool("leftTurn", true);
        }

        if(!Input.GetKey("q"))
        {
            personnageAnim.SetBool("leftTurn", false);
            
        }

        if(Input.GetKeyDown("g"))
        {
            personnageAnim.SetBool("cap", !personnageAnim.GetBool("cap"));
        }

        






        if (Input.GetKeyDown(KeyCode.Space) && Player.isGrounded)//&& Player.isGrounded
        {
            personnageAnim.SetBool("jump", true);
            DirectionalDeplacement.y = jump;

        }

        if (!Player.isGrounded)
        {
            personnageAnim.SetBool("jump", false);
            DirectionalDeplacement.y -= gravite * Time.deltaTime;
        }

        //pour les animations

        //pour marcher
        if ((Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow)) && !Input.GetKey(KeyCode.LeftShift))
        {
            personnageAnim.SetBool("walk", true);
        }
        if (!Input.GetKey(KeyCode.Z) && !Input.GetKey(KeyCode.UpArrow))
        {
            personnageAnim.SetBool("walk", false);
        }

        //pour courir
        if ((Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow)) && Input.GetKey(KeyCode.LeftShift))
        {
            personnageAnim.SetBool("run", true);
            personnageAnim.SetBool("walk", false);
        }
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            personnageAnim.SetBool("run", false);
        }

        
    }

    public void pushPull()
    {
        personnageAnim.SetBool("push", true);
    }
}