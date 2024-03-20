using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador_Movimiento : MonoBehaviour
{
    [SerializeField] public float velocidadMovimiento = 0f;

    [SerializeField] public float velocidadSalto = 0f;


    Rigidbody2D rb2D;
    SpriteRenderer sR;
    Animator animator;

    private bool mirandoDerecha = true;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        sR = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        //Esta cayendo
        if (!esEnSuelo.esSuelo)
        {
            animator.SetBool("esCayendo", true);
        }
        //Esta en suelo
        else
        {
            animator.SetBool("esCayendo", false);
        }
        //Esta corriendo hacia la derecha
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(velocidadMovimiento, rb2D.velocity.y);
            sR.flipX = false;
            animator.SetBool("esCorriendo", true);
        }
        //Esta corriendo hacia la izquierda
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-velocidadMovimiento, rb2D.velocity.y);
            sR.flipX = true;
            animator.SetBool("esCorriendo", true);
        }
        //Esta quieto
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("esCorriendo", false);
        }
        //Esta saltando
        if(Input.GetKey("space") && esEnSuelo.esSuelo)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.y, velocidadSalto);
            animator.SetBool("esCorriendo", true);
        }
    
    }
}
