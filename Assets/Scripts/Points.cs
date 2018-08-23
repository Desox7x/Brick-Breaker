using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    public static int score = 0;
    public Text scoreText;


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
    }
}
