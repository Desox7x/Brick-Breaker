using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour {
    public Life vidas;
    
	// Use this for initialization
	void OnTriggerEnter () {
        vidas.PerderVida();
	}
	
	
}
