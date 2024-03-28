using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manejador_Juego : MonoBehaviour
{

    public int vidas;

    public Text juegoTerminado;
    public Manejador_Audio manejador_Audio;
    private bool juegoPausado = false;
    private float duracionPausa;
    // Start is called before the first frame update
    void Start()
    {
        vidas = 2;
        juegoTerminado.enabled = false;
        manejador_Audio = FindObjectOfType<Manejador_Audio>();
    }

    // Update is called once per frame
    void Update()
    {
        if (juegoPausado)
        {

            duracionPausa -= Time.unscaledDeltaTime;

            if (duracionPausa <= 0)
            {
                ReanudarJuego();
            }
        }
    }

    public void PerderVida()
    {
        vidas -= 1;
        if(vidas == 0)
        {
            manejador_Audio.reproducir(3, 0.5f, false);
            SceneManager.LoadScene(0);
        }
    }

    public int ObtenerVidas()
    {
        return vidas;
    }

    public void Ganar()
    {
        juegoTerminado.enabled = true;
    }

    void PausarJuego(float tiempo)
    {
        duracionPausa = tiempo;
        juegoPausado = true;
        Time.timeScale = 0f;
    }

    void ReanudarJuego()
    {
        Time.timeScale = 1f;
        juegoPausado = false;
    }
}
