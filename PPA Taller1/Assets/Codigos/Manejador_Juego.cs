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

    // Start is called before the first frame update
    void Start()
    {
        vidas = 2;
        juegoTerminado.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerderVida()
    {
        vidas -= 1;
        if(vidas == 0)
        {
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
}
