using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerBehaviour : MonoBehaviour {

    public UIManager UI;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("left"))
        {
            transform.Rotate(Vector3.forward, globalVariables.speed * 1.8f); //TODO: speed scaling here
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(Vector3.forward, globalVariables.speed * -1.8f); //TODO: speed scaling here
        }

    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Block") { 
            UI.setGameOver();
        }
    }
}
