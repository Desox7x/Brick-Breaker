using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour {

    public AudioSource rebote;
    public AudioSource punto;

	void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bloque"))
        {
            punto.Play();
        } else
        {
            rebote.Play();
        }
        /**
         * Si el gameObject colisiona con otro objeto dentro
         * de la etiqueta "Bloque", entonces sonará el sonido
         * "punto", sino se reproducirá el sonido de rebote
         **/ 
    }
}
