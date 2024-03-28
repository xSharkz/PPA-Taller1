using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class Manejador_Audio : MonoBehaviour
{
    public AudioSource sonido;
    public AudioClip[] sonidos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reproducir(int index, float volumen, bool esLoop)
    {
        sonido.clip = sonidos[index];
        sonido.volume = volumen;
        sonido.loop = esLoop;
        sonido.Play();
    }

    public void parar()
    {
        sonido.Stop();
    }
}
