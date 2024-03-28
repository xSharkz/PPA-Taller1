using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Jugador_Movimiento : MonoBehaviour
{
    [SerializeField] public float velocidadMovimiento = 0f;

    [SerializeField] public float velocidadSalto = 0f;

    private Manejador_Juego manejador_Juego;
    private Manejador_Audio manejador_Audio;
    Rigidbody2D rb2D;
    SpriteRenderer sR;
    Animator animator;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        sR = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        manejador_Juego = FindObjectOfType<Manejador_Juego>();
        manejador_Audio = FindObjectOfType<Manejador_Audio>();
    }

    private void FixedUpdate()
    {
        //Esta saltando
        if (Input.GetKey("space") && esEnSuelo.esSuelo)
        {
            manejador_Audio.reproducir(2, 0.3f, false);
            rb2D.velocity = new Vector2(rb2D.velocity.y, velocidadSalto);
            animator.SetBool("esSaltando", true);
        }
        //Esta cayendo
        if (!esEnSuelo.esSuelo)
        {
            animator.SetBool("esSaltando", false);
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
        //Esta herido
        if (manejador_Juego.ObtenerVidas() < 2)
        {
            if(!animator.GetBool("esHerido"))
            {
                manejador_Audio.reproducir(1, 0.3f, false);
            }
            animator.SetBool("esHerido", true);
        }
        //No esta herido
        else
        {
            animator.SetBool("esHerido", false);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo_Pasto"))
        {
            manejador_Audio.reproducir(0, 0.3f, false);
        }
    }

}
