using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour {

    private SpriteRenderer sr;
    private int alpha = 0;

	// Use this for initialization
	void Start () {
        if (globalVariables.visibleLater)
        {
            sr = GetComponent<SpriteRenderer>();
        }
    }
	
	// Update is called once per frame
	void Update () {    
        if (transform.position.y < 2)
        {
            sr.color = new Color32(255, 255, 255, (byte) alpha);
            if (alpha <= 250)
            {
                alpha += 5;
            }
        }else
        {
            sr.color = new Color32(255, 255, 255, 0);
        }
        transform.Translate(Vector3.down * Time.deltaTime * globalVariables.speed * 1.1f);

       
	}
}
