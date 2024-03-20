using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador_Movimiento : MonoBehaviour
{
    [SerializeField] public float velocidadMovimiento = 0f;

    [SerializeField] public float velocidadSalto = 0f;


    Rigidbody2D rb2D;

    private bool mirandoDerecha = true;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(velocidadMovimiento, rb2D.velocity.y);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-velocidadMovimiento, rb2D.velocity.y);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }
        if(Input.GetKey("space") && esEnSuelo.esSuelo)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.y, velocidadSalto);
        }
    }
}
