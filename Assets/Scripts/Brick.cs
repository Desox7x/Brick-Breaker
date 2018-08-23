using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public GameObject efectoParticulas;

	void OnCollisionEnter()
    {
        Instantiate(efectoParticulas, transform.position, Quaternion.identity); //Instanciar el efecto de particulas al destruir
        Destroy(gameObject);
    }

}
