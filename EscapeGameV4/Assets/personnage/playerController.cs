using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Animator personnageAnim;
    //on definit la gravité pour faire redescendre le personnage apres un saut plus ou moins rapidement
    int gravite = 20;
    //on crée un un float qui va gérer la vitesse de déplacement de notre personnage
    public float speed = 3;
    //vitesse de deplacement lorsque le personnage court
    public float runSpeed = 6;
    //pour régler la hauteur du saut
    public int jump = 5;
    private Vector3 DirectionalDeplacement = Vector3.zero;
    private CharacterController Player;
    //on va faire tourner le personnage à l'aide de la sourie; on va donc créer une variable pour changer la sensiblité
    public float rotationSensi;


    public float speedV = 2.0f;
    private float pitch = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        //on récupère le personnage controller
        Player = GetComponent<CharacterController>();
        //on récupere l'animator du perso
        personnageAnim = GetComponent<Animator>();
        //initialisation de la vitesse de rotation du personnage
        rotationSensi = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //pitch -= speedV * Input.GetAxis("Mouse Y");
        //camera.transform.eulerAngles.Set(pitch, camera.transform.eulerAngles.y, camera.transform.eulerAngles.z);

        //on va donc faire évoluer les coordonées du personnage
        DirectionalDeplacement.z = Input.GetAxisRaw("Vertical");
        DirectionalDeplacement.x = Input.GetAxisRaw("Horizontal");
        //pour le déplacement du personnage
        DirectionalDeplacement = transform.TransformDirection(DirectionalDeplacement);
        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    Player.Move(DirectionalDeplacement * Time.deltaTime * runSpeed);
        //}
        //else 
        //{
        //    Player.Move(DirectionalDeplacement * Time.deltaTime * speed);
        //}

        //pour faire tourner le personnage sur lui mmeme avec q et d 
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotationSensi, 0);
        }

        if (Input.GetKey("q") || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotationSensi, 0);
        }



        //saut du personnage quand on appui sur espace

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

        //pour les animation

        //pour marcher
        if ((Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow)) && !Input.GetKey(KeyCode.LeftShift))
        {
            personnageAnim.SetBool("walk", true);
        }
        if (!Input.GetKey(KeyCode.Z) && !Input.GetKey(KeyCode.UpArrow))
        {
            personnageAnim.SetBool("walk", false);
        }

        //0pour courir
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
}
