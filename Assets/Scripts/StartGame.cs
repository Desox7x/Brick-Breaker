﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Points.score = 0;
            Life.Vidas = 5;
            SceneManager.LoadScene("Nivel1"); //Carga la escena "Nivel 1"
        }	
	}
}
