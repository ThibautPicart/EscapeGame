using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //on definit la gravité pour faire redescendre le personnage apres un saut plus ou moins rapidement
    int gravite = 20;
    //on crée un un float qui va gérer la vitesse de déplacement de notre personnage
    public float speed = 5;
    //pour régler la hauteur du saut
    public int jump = 5;
    private Vector3 DirectionalDeplacement = Vector3.zero;
    private CharacterController Player;
    //on va faire tourner le personnage à l'aide de la sourie; on va donc créer une variable pour changer la sensiblité
    public int sensibiliteSourie;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //on va donc faire évoluer les coordonées du personnage
        DirectionalDeplacement.z = Input.GetAxisRaw("Vertical");
        DirectionalDeplacement.x = Input.GetAxisRaw("Horizontal");
        //pour le déplacement du personnage
        DirectionalDeplacement = transform.TransformDirection(DirectionalDeplacement);
        Player.Move(DirectionalDeplacement * Time.deltaTime * speed);
        //pour faire pivoter le personnage à l'aide de la sourie (uniquement l'axe horizontale
        //on sait qu'il faut utiliser mouse x en allant dans project setting puis Input sur unity
        transform.Rotate(0, Input.GetAxisRaw("Mouse X")*sensibiliteSourie, 0);

        //saut du personnage quand on appui sur espace

        if (Input.GetKeyDown(KeyCode.Space ) && Player.isGrounded)//&& Player.isGrounded
        {
            DirectionalDeplacement.y = jump;
        }

        if (!Player.isGrounded)
        {
            DirectionalDeplacement.y -= gravite * Time.deltaTime;
        }

    }
}
