using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {

    public static int Vidas = 4;
    public Text lifeText;

    public MovimientoBarra barrita;
    public MovimientoBola bolita;

    void Start () {
        Update(); 
	}
	void Update()
    {
        lifeText.text = "Lives: " + Vidas; //Se muestra la cantidad de vidas declaradas al inicio del juego
    }
	// Update is called once per frame
	public void PerderVida () {
        Vidas--; //Se restan las vidas
        Update();
        
        barrita.Reset();
        bolita.Reset();
        //Cuando se pierde una vida se resetean la barra y la bola
	}
}
