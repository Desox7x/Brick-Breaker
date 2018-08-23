using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBola : MonoBehaviour {

    public float InitSpeed = 600f;
    public Rigidbody rig;
    bool inGame;
    Vector3 InitPos;
    public Transform barra;
	// Use this for initialization
	void Start () {
        InitPos = transform.position;
	}
    public void Reset() {
        transform.position = InitPos;
        transform.SetParent(barra); //Cuando se pierda, se reiniciara y volverá a ser hija de la barra
        inGame = false;
        StopMovement();
    }
    public void StopMovement()
    {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {
        if (!inGame && Input.GetButtonDown("Fire1")) {
            inGame = true;
            transform.SetParent(null); //La bolita dejará de ser hija de la barra, así podra moverse libremente cuando se lance
            rig.isKinematic = false; //La bolita utilizará el motor fisico en vez de el transform cuando comience a jugar
            rig.AddForce(new Vector3(InitSpeed, InitSpeed, 0)); //Le aplica una fuerza en X y Y 
        }
		
	}
}
