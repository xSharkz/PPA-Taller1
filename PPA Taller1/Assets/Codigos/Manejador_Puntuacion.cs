using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manejador_Puntuacion : MonoBehaviour
{
    // Start is called before the first frame update
    public Text monedasRecolectadas;

    public Text monedasTotales;

    public int monedasTotalesNivel;
    public int monedasRecolectadasNivel;
    public Manejador_Audio manejador_Audio;
    private bool esAbierto = false;
    void Start()
    {
        monedasTotalesNivel = transform.childCount;
        manejador_Audio = FindObjectOfType<Manejador_Audio>();
    }

    // Update is called once per frame
    void Update()
    {
        monedasTotales.text = monedasTotalesNivel.ToString();
        monedasRecolectadas.text = transform.childCount.ToString();

        monedasRecolectadasNivel = transform.childCount;
        if(ObtenerMonedas() == 0 && esAbierto == false)
        {
            esAbierto = true;
            manejador_Audio.reproducir(4, 0.5f, false);
        }
    }

    public int ObtenerMonedas()
    {
        return monedasRecolectadasNivel;
    }
}
