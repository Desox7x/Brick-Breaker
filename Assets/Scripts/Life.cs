using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {

    public static int Vidas = 5;
    public Text lifeText;
    public GameObject gameOver;
    public NextLevel nextLevel;

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
    public void PerderVida() {

        if (Vidas <= 0) return;
        Vidas--; //Se restan las vidas
        Update();
        
        if(Vidas <= 0)
        {
            gameOver.SetActive(true); //Aparece el mensaje de Game Over
            bolita.StopMovement(); //Detener movimiento de la bola
            barrita.enabled = false; //Desactivamos el Script de la barra para que no se mueva con el Game Over

            nextLevel.LoadLevel = "Menu";
            nextLevel.StartLoading();

        }
        else
        {
            barrita.Reset();
            bolita.Reset();
        } //Cuando se pierde una vida se resetean la barra y la bola


    }
}
