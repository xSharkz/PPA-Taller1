using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sierra_Giro : MonoBehaviour
{
    public float velocidadRotacion = 100f; // Velocidad de rotación en grados por segundo

    public Manejador_Juego manejador_Juego;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        //Vector3.right = x, Vector3.up = y, Vector3.forward = z
        transform.Rotate(Vector3.forward, velocidadRotacion * Time.deltaTime); ;
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            manejador_Juego.PerderVida();
        }
    }
}
