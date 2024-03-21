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
    void Start()
    {
        monedasTotalesNivel = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        monedasTotales.text = monedasTotalesNivel.ToString();
        monedasRecolectadas.text = transform.childCount.ToString();

        monedasRecolectadasNivel = transform.childCount;
    }

    public int ObtenerMonedas()
    {
        return monedasRecolectadasNivel;
    }
}
