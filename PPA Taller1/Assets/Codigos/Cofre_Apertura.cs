using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre_Apertura : MonoBehaviour
{
    Animator animator;
    private Manejador_Puntuacion manejador_Puntuacion;
    private Manejador_Juego manejador_Juego;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        manejador_Puntuacion = FindObjectOfType<Manejador_Puntuacion>();
        manejador_Juego = FindObjectOfType<Manejador_Juego>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador") && manejador_Puntuacion.ObtenerMonedas() == 0)
        {
            animator.SetBool("esAbierto", true);
            manejador_Juego.Ganar();
        }
    }
}
