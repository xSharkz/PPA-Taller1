using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Moneda_Recolectar : MonoBehaviour
{

    private Manejador_Audio manejador_Audio;
    // Start is called before the first frame update
    void Start()
    {
        manejador_Audio = FindAnyObjectByType<Manejador_Audio>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Jugador"))
        {
            manejador_Audio.reproducir(0,0.3f,false);
            Destroy(gameObject);
        }
    }
}
