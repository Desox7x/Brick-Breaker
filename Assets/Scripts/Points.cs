using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    public static int score = 0;
    public Text scoreText;

    public GameObject nivelCompletado;
    public GameObject juegoCompletado;

    public NextLevel nextLevel;
    public MovimientoBola pelota;
    public MovimientoBarra barra;

    public Transform BrickContainer;

    void Start()
    {
        Update();
    }
	void Update()
    {
        scoreText.text = "Score: " + Points.score;

    }
    public void anotarPuntos()
    {
        Points.score = Points.score + 2;
        Update();

        if (BrickContainer.childCount <= 0) //Si el numero de ladrillos es menor o igual a cero...
        {
            pelota.StopMovement(); //... la pelota se detendrá
            barra.enabled = false; // y la barra también
            if (nextLevel.LastLevel())                        
            {                               
                juegoCompletado.SetActive(true);                    
            }
            else
            {
                nivelCompletado.SetActive(true);
            }
            nextLevel.StartLoading(); //Empezará a cargar la siguiente escena
            /**Si el siguiente nivel es el último entonces
             * aparecerá el mensaje de juego completado; sino,
             * aparecerá el mensaje de nivel completado
             **/ 
        }
    }
}
