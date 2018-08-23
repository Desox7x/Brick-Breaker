using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBarra : MonoBehaviour {
    public float speed = 8f;
    Vector3 InitPos;
	// Use this for initialization
	void Start () {
        InitPos = transform.position;
	}
    public void Reset() {
        transform.position = InitPos;
    }
	
	// Update is called once per frame
	void Update () {
        float xhorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (xhorizontal * speed * Time.deltaTime);
        //Con time.deltatime se calcula la velocidad para un solo fotograma por segundo
        transform.position = new Vector3(Mathf.Clamp(posX, -10, 10), transform.position.y, 0);
        /**
         * if(posX>8){posX = 8}
         * if(posX<-8){posX = -8}
         **/
	}
}
