using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Caida : MonoBehaviour
{
    public Transform puntoInicial;
    public float distanciaActivacion = 100000f;
    public float velocidadCaida = 5f;
    public float velocidadRegreso = 2f;
    public LayerMask capaSuelo;

    private Vector3 posicionInicial;
    private bool activado = false;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        if (!activado)
        {
            // Comprobar si el jugador está por debajo del bloque a una cierta distancia
            if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, distanciaActivacion, capaSuelo))
            {
                if (hit.collider.CompareTag("Jugador"))
                {
                    activado = true;
                }
            }
        }
        else
        {
            // Mover el bloque hacia abajo
            transform.Translate(Vector3.down * velocidadCaida * Time.deltaTime);

            // Comprobar si ha chocado con el suelo
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, Mathf.Infinity, capaSuelo))
            {
                // Si choca con el suelo, volver al punto inicial
                if (hit.distance < 0.01f)
                {
                    transform.position = Vector3.MoveTowards(transform.position, posicionInicial, velocidadRegreso * Time.deltaTime);
                    if (transform.position == posicionInicial)
                    {
                        activado = false;
                    }
                }
            }
        }
    }
}
