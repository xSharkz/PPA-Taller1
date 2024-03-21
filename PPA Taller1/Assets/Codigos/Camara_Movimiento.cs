using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_Movimiento : MonoBehaviour
{
    public Transform jugador;
    public Vector3 offset = new Vector3(0f, 5f, -10f);

    void Update()
    {
        if (!jugador)
            return;
        Vector3 nuevaPosicion = jugador.position + offset;

        transform.position = Vector3.Lerp(transform.position, nuevaPosicion, Time.deltaTime * 5f);
    }

}
