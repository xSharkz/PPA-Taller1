using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Camara_Movimiento : MonoBehaviour
{
    public Transform jugador;
    public Vector3 offset = new Vector3(0f, 5f, -10f);
    private Manejador_Juego manejador_Juego;
    public AudioSource sonido;
    private void Start()
    {
        sonido.pitch = 1f;
        manejador_Juego = FindAnyObjectByType<Manejador_Juego>();
    }
    void Update()
    {
        if (!jugador)
            return;
        Vector3 nuevaPosicion = jugador.position + offset;

        transform.position = Vector3.Lerp(transform.position, nuevaPosicion, Time.deltaTime * 5f);

        if (manejador_Juego.ObtenerVidas() == 1)
        {
            sonido.pitch = 2f;
        }


    }

}
