using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {

    public static int Vidas = 4;
    public Text lifeText;
    public GameObject gameOver;

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

        if (Vidas <= 0) return;
        Vidas--; //Se restan las vidas
        Update();
        
        if(Vidas <= 0)
        {
            gameOver.SetActive(true); //Aparece el mensaje de Game Over
        }
        else
        {
            barrita.Reset();
            bolita.Reset();
        } //Cuando se pierde una vida se resetean la barra y la bola


    }
}
