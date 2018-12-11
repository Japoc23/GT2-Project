using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelected : MonoBehaviour {

    bool selected;
	// Use this for initialization
	void Start () {
        if (gameObject.name == "StartFasterButton") { selected = globalVariables.startFaster; }
        if (gameObject.name == "LessDistanceButton") { selected = globalVariables.lessDistance; }
        if (gameObject.name == "VisibleLaterButton") { selected = globalVariables.visibleLater; }

        if (selected)
        {
            transform.Rotate(Vector3.forward, -15f);
            Button button = gameObject.GetComponent("Button") as Button;
            ColorBlock cb = button.colors;
            cb.normalColor = new Color32(144, 72, 72, 255);
            cb.highlightedColor = new Color32(200, 159, 159, 255);
            cb.pressedColor = new Color32(255, 200, 200, 255);
            button.colors = cb;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
       

        if (selected)
        {
            transform.Rotate(Vector3.forward, 15f);
            Button button = gameObject.GetComponent("Button") as Button;
            ColorBlock cb = button.colors;
            cb.normalColor = new Color32(72,72,72,255);
            cb.highlightedColor = new Color32(159,159,159,255);
            cb.pressedColor = new Color32(200,200,200,255);
            button.colors = cb;
        }
        else
        {
            transform.Rotate(Vector3.forward, -15f);
            Button button = gameObject.GetComponent("Button") as Button;
            ColorBlock cb = button.colors;
            cb.normalColor = new Color32(144, 72, 72, 255);
            cb.highlightedColor = new Color32(200, 159, 159, 255);
            cb.pressedColor = new Color32(255, 200, 200, 255);
            button.colors = cb;
        }

        selected = !selected;
        if (gameObject.name == "StartFasterButton") { globalVariables.startFaster = selected; }
        if (gameObject.name == "LessDistanceButton") { globalVariables.lessDistance = selected; }
        if (gameObject.name == "VisibleLaterButton") { globalVariables.visibleLater = selected; }

    }
}
